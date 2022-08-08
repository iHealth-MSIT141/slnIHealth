using Microsoft.AspNetCore.Mvc;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class OrderManageController : Controller
    {

        IHealthContext db = new IHealthContext();
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult OrderList(int? page)
        {
            var pro = (from o in db.TOrders
                       join p in db.TPaymentCategories
                       on o.FPaymentCategoryId equals p.FPaymentCategoryId
                       join s in db.TStatuses
                       on o.FStatusNumber equals s.FStatusNumber
                       join m in db.TMembers
                       on o.FMemberId equals m.FMemberId
                       select new COrderViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FPaymentCategoryId = o.FPaymentCategoryId,
                           fPayment = o.FPaymentCategory,
                           FDate = o.FDate,
                           FAddress = o.FAddress,
                           FMemberId = o.FMemberId,
                           fmember = o.FMember,
                           FContact = o.FContact,
                           FPhone = o.FPhone,
                           FRemarks = o.FRemarks,
                           FStatusNumber = o.FStatusNumber,
                           fstatus = o.FStatusNumberNavigation
                       }).ToList();
            var pageNumber = page ?? 1;
            var onePageOfPro = pro.ToPagedList(pageNumber, 10);
            ViewBag.onePageOfPro = onePageOfPro;
            return View(onePageOfPro);          
        }
        public IActionResult OrderDetailList(int? id)
        {
            IHealthContext db = new IHealthContext();        
            var odt = (from o in db.TOrderDetails
                       where o.FOrderId == id
                       //where o.FOrderDetailsId == id
                       join or in db.TOrders
                       on o.FOrderId equals or.FOrderId
                       join d in db.TDiscounts
                       on o.FDiscountId equals d.FDiscountId
                       join p in db.TProducts
                       on o.FProductId equals p.FProductId
                       select new COrderDetailViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FOrderDetailsId = o.FOrderDetailsId,
                           FQuantity = o.FQuantity,
                           FUnitprice = o.FUnitprice,
                           fdiscount = o.FDiscount,
                           FDiscountId = o.FDiscountId,
                           FProductId = o.FProductId,
                           fproduct = o.FProduct
                       }).ToList();
            if (odt == null)
            {
                return RedirectToAction("OrderList");
            }
            return View(odt);
        }
        public IActionResult OrderEdit(int? id)
        {
            //TOrder od = db.TOrders.FirstOrDefault(p => p.FOrderId == id);
            var pro = (from o in db.TOrders
                       where o.FOrderId == id
                       join p in db.TPaymentCategories
                       on o.FPaymentCategoryId equals p.FPaymentCategoryId
                       join s in db.TStatuses
                       on o.FStatusNumber equals s.FStatusNumber
                       join m in db.TMembers
                       on o.FMemberId equals m.FMemberId
                       select new COrderViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FPaymentCategoryId = o.FPaymentCategoryId,
                           fPayment = o.FPaymentCategory,
                           FDate = o.FDate,
                           FAddress = o.FAddress,
                           FMemberId = o.FMemberId,
                           fmember = o.FMember,
                           FContact = o.FContact,
                           FPhone = o.FPhone,
                           FRemarks = o.FRemarks,
                           FStatusNumber = o.FStatusNumber,
                           fstatus = o.FStatusNumberNavigation
                       }).ToList();
            if (pro == null)
            {
                return RedirectToAction("OrderList");
            }
            return View(pro);           
        }
        [HttpPost]
        public IActionResult OrderEdit(COrderViewModel co)
        {
            IHealthContext db = new IHealthContext();
            TOrder ord = db.TOrders.FirstOrDefault(p => p.FOrderId == co.FOrderId);
            var pro = (from o in db.TOrders
                       where o.FOrderId == co.FOrderId
                       join p in db.TPaymentCategories
                       on o.FPaymentCategoryId equals p.FPaymentCategoryId
                       join s in db.TStatuses
                       on o.FStatusNumber equals s.FStatusNumber
                       join m in db.TMembers
                       on o.FMemberId equals m.FMemberId
                       select new COrderViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FPaymentCategoryId = o.FPaymentCategoryId,
                           fPayment = o.FPaymentCategory,
                           FDate = o.FDate,
                           FAddress = o.FAddress,
                           FMemberId = o.FMemberId,
                           fmember = o.FMember,
                           FContact = o.FContact,
                           FPhone = o.FPhone,
                           FRemarks = o.FRemarks,
                           FStatusNumber = o.FStatusNumber,
                           fstatus = o.FStatusNumberNavigation
                       }).FirstOrDefault();
            if (ord != null)
            {
                pro.FPaymentCategoryId = co.FPaymentCategoryId;
                pro.fPayment = co.fPayment;
                pro.fstatus = co.fstatus;
                pro.FDate = co.FDate;
                pro.FAddress = co.FAddress;
                pro.FContact = co.FContact;
                pro.FPhone = co.FPhone;
                pro.FRemarks = co.FRemarks;
                pro.FStatusNumber = co.FStatusNumber;
                //=====================================                
                ord.FPaymentCategoryId = pro.FPaymentCategoryId;
                ord.FPhone = pro.FPhone;
                ord.FContact = pro.FContact;
                ord.FAddress = pro.FAddress;
                ord.FDate = pro.FDate;
                ord.FStatusNumber = pro.FStatusNumber;
                ord.FRemarks = pro.FRemarks;
                ord.FOrderId = pro.FOrderId;             
                db.SaveChanges();
            }
            return RedirectToAction("OrderList");
        }
        public IActionResult OrderDetailEdit(int? id)
        {
            TOrderDetail od = db.TOrderDetails.FirstOrDefault(p => p.FOrderDetailsId == id);
            var odt = (from o in db.TOrderDetails
                       //where o.FOrderId == id
                       where o.FOrderDetailsId == id
                       join or in db.TOrders
                       on o.FOrderId equals or.FOrderId
                       join d in db.TDiscounts
                       on o.FDiscountId equals d.FDiscountId
                       join p in db.TProducts
                       on o.FProductId equals p.FProductId
                       select new COrderDetailViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FOrderDetailsId = o.FOrderDetailsId,
                           FQuantity = o.FQuantity,
                           FUnitprice = o.FUnitprice,
                           fdiscount = o.FDiscount,
                           FDiscountId = o.FDiscountId,
                           FProductId = o.FProductId,
                           fproduct = o.FProduct
                       }).ToList();
            if (odt == null)
            {
                return RedirectToAction("OrderdetailList");
            }
            return View(odt);          
        }
        [HttpPost]
        public IActionResult OrderDetailEdit(COrderDetailViewModel co)
        {
            IHealthContext db = new IHealthContext();
            TOrderDetail od = db.TOrderDetails.FirstOrDefault(p => p.FOrderDetailsId == co.FOrderDetailsId);
            var odt = (from o in db.TOrderDetails
                           //where o.FOrderId == id
                       where o.FOrderDetailsId == co.FOrderDetailsId
                       join or in db.TOrders
                       on o.FOrderId equals or.FOrderId
                       join d in db.TDiscounts
                       on o.FDiscountId equals d.FDiscountId
                       join p in db.TProducts
                       on o.FProductId equals p.FProductId
                       select new COrderDetailViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FOrderDetailsId = o.FOrderDetailsId,
                           FQuantity = o.FQuantity,
                           FUnitprice = o.FUnitprice,
                           fdiscount = o.FDiscount,
                           FDiscountId = o.FDiscountId,
                           FProductId = o.FProductId,
                           fproduct = o.FProduct
                       }).FirstOrDefault();
            if (od != null)
            {
                odt.FQuantity = co.FQuantity;
                odt.FUnitprice = co.FUnitprice;
                odt.FDiscountId = co.FDiscountId;
                odt.FOrderDetailsId = co.FOrderDetailsId;
                odt.FProductId = co.FProductId;
                //=======================================
                od.FQuantity = odt.FQuantity;
                od.FUnitprice = odt.FUnitprice;
                od.FDiscountId = odt.FDiscountId;
                od.FOrderDetailsId = odt.FOrderDetailsId;
                od.FProductId = odt.FProductId;               
                db.SaveChanges();
            }
            return RedirectToAction("OrderList");
        }
        public IActionResult Statusselect(int id)
        {
            IHealthContext db = new IHealthContext();
            var pro = (from o in db.TOrders
                       join p in db.TPaymentCategories
                       on o.FPaymentCategoryId equals p.FPaymentCategoryId
                       join s in db.TStatuses
                       on o.FStatusNumber equals s.FStatusNumber
                       where o.FStatusNumber == id
                       join m in db.TMembers
                       on o.FMemberId equals m.FMemberId
                       select new COrderViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FPaymentCategoryId = o.FPaymentCategoryId,
                           fPayment = o.FPaymentCategory,
                           FDate = o.FDate,
                           FAddress = o.FAddress,
                           FMemberId = o.FMemberId,
                           fmember = o.FMember,
                           FContact = o.FContact,
                           FPhone = o.FPhone,
                           FRemarks = o.FRemarks,
                           FStatusNumber = o.FStatusNumber,
                           fstatus = o.FStatusNumberNavigation
                       }).ToList();
            return Json(pro);
        }
        public IActionResult Statusselectall()
        {
            IHealthContext db = new IHealthContext();
            var pro = (from o in db.TOrders
                       join p in db.TPaymentCategories
                       on o.FPaymentCategoryId equals p.FPaymentCategoryId
                       join s in db.TStatuses
                       on o.FStatusNumber equals s.FStatusNumber
                       join m in db.TMembers
                       on o.FMemberId equals m.FMemberId
                       select new COrderViewModel()
                       {
                           FOrderId = o.FOrderId,
                           FPaymentCategoryId = o.FPaymentCategoryId,
                           fPayment = o.FPaymentCategory,
                           FDate = o.FDate,
                           FAddress = o.FAddress,
                           FMemberId = o.FMemberId,
                           fmember = o.FMember,
                           FContact = o.FContact,
                           FPhone = o.FPhone,
                           FRemarks = o.FRemarks,
                           FStatusNumber = o.FStatusNumber,
                           fstatus = o.FStatusNumberNavigation
                       }).ToList();
            return Json(pro);
        }
        public IActionResult Pricechange(int id)
        {
            IHealthContext db = new IHealthContext();
            var pro = (from p in db.TProducts
                       where p.FProductId == id
                       select p).FirstOrDefault();

            return Json(pro);
        }
    }
}
