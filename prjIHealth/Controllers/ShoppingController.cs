using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class ShoppingController : Controller
    {
        public IActionResult ShoppingCartList()
        {
            return View();
        }

        public IActionResult CheckOut() 
        {
            return View();
        }

        public IActionResult ShowShoppingMall(CKeywordViewModel vModel, int? id)
        {
            IHealthContext dblIHealth = new IHealthContext();
            IEnumerable<TProduct> dataShoppingItems = null;
            //dataShoppingItems = from t in dblIHealth.TProducts
            //                    select t;

            //TODO 
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                if (id == null)
                {
                    dataShoppingItems = from t in dblIHealth.TProducts
                                        select t;


                }
                else
                {
                    dataShoppingItems = from t in dblIHealth.TProducts
                                        where t.FCategoryId == id
                                        select t;
                }
            }
            else
            {
                dataShoppingItems = from t in dblIHealth.TProducts
                                    where t.FProductName.Contains(vModel.txtKeyword)
                                    select t;
            }

            return View(dataShoppingItems);
        }

        public IActionResult AddToTrack(int? id)
        {
            IHealthContext dblIHealth = new IHealthContext();
            TProduct prod = dblIHealth.TProducts.FirstOrDefault(t => t.FProductId == id);
            if (prod == null)
            {
                return RedirectToAction("ShowShoppingMall");
            }
            return View(prod);
        }

        [HttpPost]
        public ActionResult AddToTrack(CAddToTrackViewModel vModel)
        {
            IHealthContext dblIHealth = new IHealthContext();
            TTrackList TableTrackList = new TTrackList();

            vModel.MemberFid = 1;
            vModel.txtFid = 1;
            TableTrackList.FMemberId = vModel.MemberFid;
            TableTrackList.FProductId = vModel.txtFid;
            dblIHealth.TTrackLists.Add(TableTrackList);
            dblIHealth.SaveChanges();
            return RedirectToAction("ShowShoppingMall");

        }

        public IActionResult DescProduct()
        {
            IHealthContext dblIHealth = new IHealthContext();
            IEnumerable<TProduct> dataShoppingItems = null;
            dataShoppingItems = from t in dblIHealth.TProducts
                                orderby t.FUnitprice descending
                                select t;

            return View(dataShoppingItems);
        }

        public ActionResult ShowProductDetail(int? id)
        {
            return View();
        }
    }
}
