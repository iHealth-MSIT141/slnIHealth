using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjiHealth.Models;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.ViewModels
{
    public class CDiaryViewModel
    {
        IHealthContext db = new IHealthContext();

        //載入全部食物列表
        public IEnumerable<TFoodCalory> AllFoods
        {
            get
            {
                return db.TFoodCalories;
            }
        }

        //TODO 抓User的ID:  if (HttpContext.Session.Keys.Contains(CDictionary.SK_Logined_User))...
        //public IActionResult CartView()
        //{
        //    if (HttpContext.Session.Keys.Contains(CDictionary.SK_已經購買的_商品們_列表))
        //    {
        //        string jsonCart = HttpContext.Session.GetString(CDictionary.SK_已經購買的_商品們_列表);
        //        List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
        //        return View(cart);
        //    }
        //    else
        //        return RedirectToAction("List");
        //}
        int userId = 8;

        //登入會員的身體數據
        public IEnumerable<CBodyRecordViewModel> BodyRecords
        {
            get
            {
                var q =db.TBodyRecords.Where(b => b.FMemberId == userId).OrderByDescending(b => b.FRecordDate);
                List<CBodyRecordViewModel> bodyRecords = new List<CBodyRecordViewModel>();
                foreach(var b in q)
                {
                    CBodyRecordViewModel bodyRecord = new CBodyRecordViewModel()
                    {
                        FBodyRecordId = b.FBodyRecordId,
                        FMemberId = b.FMemberId,
                        FRecordDate = b.FRecordDate,
                        FWorkload = b.FWorkload,
                        FHeight = b.FHeight,
                        FWeight = b.FWeight
                    };
                    bodyRecords.Add(bodyRecord);
                }
                return bodyRecords;
            }
        }

        //登入會員的飲食日誌
        public IEnumerable<TCalorieIntake> CalorieIntakes
        {
            get
            {
                var intakeRecords = db.TCalorieIntakes.Where(c=>c.FMemberId == userId).OrderBy(c => c.FIntakeTime);
                return intakeRecords;
            }
        }

    }
}
