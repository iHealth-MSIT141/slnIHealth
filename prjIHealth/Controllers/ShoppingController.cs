using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prjiHealth.Models;
using prjiHealth.ViewModels;
using prjIHealth.Controllers;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IHealthContext dblIHealth;
        public ShoppingController(IHealthContext db)
        {
            dblIHealth = db;
        }

        public IActionResult ShoppingCartList()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Shopped_Items))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_Shopped_Items);
                List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                return View(cart);
            }
            //待有資料後改回以下兩行
            else
                return RedirectToAction("ShowShoppingMall");
            //return View();
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        //商城主頁界面
        public IActionResult ShowShoppingMall()
        {
            return View();
        }

        public int TakeMemberID()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
            {
                string loginSession = HttpContext.Session.GetString(CDictionary.SK_Logined_User);
                TMember loginUser = JsonSerializer.Deserialize<TMember>(loginSession);
                int userID = loginUser.FMemberId;
                return userID;
            }
            return 0;
        }

        [HttpPost]
        public IActionResult GetProduct(CShoppingFeatureViewModel vModel)
        {

            IEnumerable<TProduct> dataShoppingItems = null;
            dataShoppingItems = from t in dblIHealth.TProducts
                                select t;
            if (vModel.sort != null)
            {
                if (vModel.sort == "asc")
                {
                    dataShoppingItems = dataShoppingItems.OrderBy(t => t.FUnitprice);
                }
                else if (vModel.sort == "desc")
                {
                    dataShoppingItems = dataShoppingItems.OrderByDescending(t => t.FUnitprice);
                }
            }

            if (vModel.categoryID != null)
            {
                if (vModel.categoryID != 0)
                {
                    dataShoppingItems = dataShoppingItems.Where(t => t.FCategoryId == vModel.categoryID);
                }
            }

            if (!string.IsNullOrEmpty(vModel.txtKeyword))
            {
                if (vModel.txtKeyword != "")
                {
                    dataShoppingItems = dataShoppingItems.Where(t => t.FProductName.Contains(vModel.txtKeyword));
                }               
            }
            return Json(dataShoppingItems);
        }

        //傳入產品、會員ID 把商品加入到資料庫當中
        public IActionResult AddToTrack(int? id)
        {
            int userID = TakeMemberID();
            var p = new CProductViewModel().ProductList.FirstOrDefault(t => t.FProductId == id);

            //判定產品有沒有曾出現於該會員的追蹤清單內
            var q = (from a in dblIHealth.TTrackLists
                     where a.FMemberId == userID && a.FProductId == id
                     select a).Count();

            if (q != 0)
            {
                return Content("你已加入追蹤清單");
            }
            else
            {
                if (p != null)
                {
                    if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))
                    {
                        TTrackList trackList = new TTrackList()
                        {
                            FMemberId = userID,
                            //TODO GET member id
                            FProductId = Convert.ToInt32(id)
                        };
                        dblIHealth.TTrackLists.Add(trackList);
                        dblIHealth.SaveChanges();
                        return Json(p);
                    }
                }
                return RedirectToAction("ShowShoppingMall");
            }
        }

        //產品明細界面
        public ActionResult ShowProductDetail(int? id)
        {
            //var prod = new CProductViewModel().ProductList.FirstOrDefault(t => t.FProductId == id);
            //var profinclude = dblIHealth.TProducts.Include(p => p.TProductsImages).Where(t => t.FProductId == id).AsEnumerable();
            TProduct prod = dblIHealth.TProducts.FirstOrDefault(t => t.FProductId == id);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            return View(prod);
        }

        [HttpPost]
        public ActionResult ShowProductDetail(CAddToCartViewModel vModel)
        {
            IHealthContext db = new IHealthContext();
            //TDiscount discount = db.TDiscounts.FirstOrDefault(t => t.FDiscountCode == vModel.discountCode);
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FProductId == vModel.txtFid);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_Shopped_Items))
            {
                list = new List<CShoppingCartItem>();
            }
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_Shopped_Items);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }

            CShoppingCartItem item = new CShoppingCartItem()
            {
                count = vModel.txtCount,
                //discount=Convert.ToDecimal(discount.FDiscountValue),
                price = (decimal)prod.FUnitprice,
                productId = vModel.txtFid,
                product = prod
            };

            if (list.Count == 0)
            {
                list.Add(item);
            }
            else
            {
                bool sameproduct = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].productId == item.productId)
                    {
                        list[i].count += item.count;
                        sameproduct = true;
                    }
                }
                if (!sameproduct)
                {
                    list.Add(item);
                }
            }
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(CDictionary.SK_Shopped_Items, jsonCart);
            return RedirectToAction("ShowShoppingMall");
        }

        //以ProductID搜對應的圖片
        public ActionResult ShowProductImages(int? id)
        {
            var images = from p in dblIHealth.TProducts
                         join i in dblIHealth.TProductsImages
                         on p.FProductId equals i.FProductId
                         where p.FProductId == id
                         select i.FImage;
            return Json(images);
        }

        //顯示各類別前3名圖片(沒用到先放著)
        public ActionResult ShowTop3Product(int? id)
        {
            // var top3PopularProduct = null;
            ArrayList list = new ArrayList();
            var top3PopularProduct = (from od in dblIHealth.TOrderDetails.Include(od => od.FProduct).ThenInclude(p => p.FCategory).AsEnumerable()
                                      where od.FProduct.FCategoryId == id
                                      group od by new
                                      {
                                          od.FProductId,
                                          od.FProduct.FProductName,
                                          od.FProduct.FCoverImage,
                                          od.FProduct.FUnitprice
                                      }
                                      into g
                                      select new
                                      {
                                          Key = g.Key,
                                          Count = g.Sum(od => od.FQuantity),
                                          Photo = g.Key.FCoverImage,
                                          UnitPrice = g.Key.FUnitprice
                                      }).OrderByDescending(p => p.Count).Take(3).ToList();

            list.Add(top3PopularProduct);

            return Json(list);
        }
        public ActionResult SuggestProduct()
        {
            ArrayList list = new ArrayList();
            Random rd = new Random(Guid.NewGuid().GetHashCode());
            int count = dblIHealth.TProducts.Count();
            int num = 0;
            for (int i = 0; i < 4; i++)
            {
                num = rd.Next(1, count);
                TProduct rdProduct = (from t in dblIHealth.TProducts
                                      where t.FProductId == num
                                      select t).FirstOrDefault();
                list.Add(rdProduct);
            }
            return Json(list);
        }
        public IActionResult CheckDiscount(string code)
        {
            IHealthContext db = new IHealthContext();
            var discount = db.TDiscounts.Where(t => t.FDiscountCode == code).Select(t => t.FDiscountValue).Distinct();
            return Json(discount);
        }

        public ActionResult ShoppingCartSession(CAddToCartViewModel vModel)
        {
            IHealthContext db = new IHealthContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FProductId == vModel.txtFid);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_Shopped_Items))
            {
                list = new List<CShoppingCartItem>();
            }
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_Shopped_Items);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }
            CShoppingCartItem item = new CShoppingCartItem()
            {
                count = vModel.txtCount,
                price = (decimal)prod.FUnitprice,
                productId = vModel.txtFid,
                product = prod
            };

            if (list.Count == 0)
            {
                list.Add(item);
            }
            else
            {
                bool sameproduct = false;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].productId == item.productId)
                    {
                        list[i].count = item.count;
                        sameproduct = true;
                    }
                }
                if (!sameproduct)
                {
                    list.Add(item);
                }
            }
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(CDictionary.SK_Shopped_Items, jsonCart);
            return RedirectToAction("ShoppingCartList");
        }
        public ActionResult ShoppingCartDelete(CAddToCartViewModel vModel)
        {
            IHealthContext db = new IHealthContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FProductId == vModel.txtFid);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_Shopped_Items))
            {
                list = new List<CShoppingCartItem>();
            }
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_Shopped_Items);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }
            CShoppingCartItem item = new CShoppingCartItem()
            {
                count = vModel.txtCount,
                price = (decimal)prod.FUnitprice,
                productId = vModel.txtFid,
                product = prod
            };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].productId == vModel.txtFid)
                    list.Remove(list[i]);
            }
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(CDictionary.SK_Shopped_Items, jsonCart);
            return RedirectToAction("ShoppingCartList");
        }
        public ActionResult ShoppingCartCheckZero(CAddToCartViewModel vModel)
        {
            IHealthContext db = new IHealthContext();
            TProduct prod = db.TProducts.FirstOrDefault(t => t.FProductId == vModel.txtFid);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_Shopped_Items))
            {
                list = new List<CShoppingCartItem>();
            }
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_Shopped_Items);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }
            CShoppingCartItem item = new CShoppingCartItem()
            {
                count = vModel.txtCount,
                price = (decimal)prod.FUnitprice,
                productId = vModel.txtFid,
                product = prod
            };
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].count == 0 || list[i].count == -1)
                    list.Remove(list[i]);
            }
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(CDictionary.SK_Shopped_Items, jsonCart);
            return RedirectToAction("CheckOut");
        }
    }
}
