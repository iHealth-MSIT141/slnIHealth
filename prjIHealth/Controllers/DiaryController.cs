using Microsoft.AspNetCore.Mvc;
using prjiHealth.ViewModels;
using prjIHealth.Models;
using prjIHealth.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjIHealth.Controllers
{
    public class DiaryController : Controller
    {
        private readonly IHealthContext db;
        public DiaryController(IHealthContext context)
        {
            db = context;
        }
        //IHealthContext db = new IHealthContext();

        //Diary主頁View
        public IActionResult DiaryMain()
        {
            string now = DateTime.Now.ToString("yyyyMM"+"32000000");
            double date = double.Parse(now);
            double[] bmis = new double[12];
            for(int i = 0; i < 12; i++)
            {
                CBodyRecordViewModel bodyRecordsViewModel = new CDiaryViewModel(db).BodyRecords.FirstOrDefault(b => double.Parse(b.FRecordDate) < date);
                bmis[i] = bodyRecordsViewModel.NumBMI;
                if (date.ToString().Substring(4, 2) == "01")
                {
                    date = date - 8900000000;
                }
                else
                {
                    date = date - 100000000;
                }
            }
            return View(bmis);

            //return View();
        }     
        
        //取得選取日期最接近的身體數據
        public IActionResult getBodyRecord(string date)
        {
            //TODO 沒有資料時顯示最舊一筆
            date = date.Replace("-", "");
            date = date + "235959";
            CBodyRecordViewModel bodyRecordsViewModel = new CDiaryViewModel(db).BodyRecords.FirstOrDefault(b => double.Parse(b.FRecordDate) < double.Parse(date));
            return Json(bodyRecordsViewModel);
        }

        //新增身體數據
        public IActionResult addBodyRecord(TBodyRecord body)
        {
            if (body.FHeight != null && body.FWeight != null && body.FWorkload != null)
            {
                //TODO tryparse
                string date = body.FRecordDate.Replace("-", "");
                int count = (new CDiaryViewModel(db)).BodyRecords.Where(b => b.FRecordDate.Substring(0, 8) == date).Count();
                double recordDate = double.Parse($"{date}000000") + count;
                TBodyRecord bodyRecord = new TBodyRecord()
                {
                    //TODO 抓memberId
                    FMemberId = 8,
                    FRecordDate = recordDate.ToString(),
                    FHeight = body.FHeight,
                    FWeight = body.FWeight,
                    FWorkload = body.FWorkload
                };
                db.TBodyRecords.Add(bodyRecord);
                db.SaveChanges();
            }
            return Content("finish", "text/plain", System.Text.Encoding.UTF8);
        }

        //載入食物列表
        public IActionResult loadAllFoods()
        {
            return Json(new CDiaryViewModel(db).AllFoods);
        }

        //新增飲食紀錄
        //TODO對同餐別同樣食物不做新增做數量修改
        public IActionResult addCalorieIntake(TCalorieIntake intake)
        {
            if (intake.FIntakeTime != null && intake.FFoodId != null && intake.FQuantity != null&& intake.FMeal!=null)
            {
                //TODO tryparse
                TCalorieIntake calorieIntake = new TCalorieIntake()
                {
                    FIntakeTime=intake.FIntakeTime.Replace("-", "") + DateTime.Now.ToString("HHmmss"),
                    //TODO 抓memberId
                    FMemberId = 8,
                    FFoodId = intake.FFoodId,
                    FQuantity = intake.FQuantity,
                    FMeal = intake.FMeal
                };
                db.TCalorieIntakes.Add(calorieIntake);
                db.SaveChanges();
            }
            return Content("finish", "text/plain", System.Text.Encoding.UTF8);
        }     
        
        //搜尋食物
        public IActionResult searchFood(CKeywordViewModel keywordViewModel)
        {
            var foods = new CDiaryViewModel(db).AllFoods.Where(f => f.FFoodName.Contains(keywordViewModel.txtKeyword));
            return Json(foods);
        }   
        
        //驗證食物名是否重複
        public IActionResult checkFoodName(CKeywordViewModel keywordViewModel)
        {
            var foods = new CDiaryViewModel(db).AllFoods.Where(f => f.FFoodName==keywordViewModel.txtKeyword);
            return Json(foods);
        }

        //新增食物
        public IActionResult addFoodCalory(TFoodCalory food)
        {
            if (food.FFoodName != null && food.FUnit != null && food.TCalorieIntakes != null)
            {
                //TODO tryparse
                //TFoodCalory foodCalory = new TFoodCalory()
                //{
                //    FFoodName=food.FFoodName,
                //    FUnit=food.FUnit,
                //    FCalories=food.FCalories
                //};這段不需要待刪除
                db.TFoodCalories.Add(food);
                db.SaveChanges();
            }
            return Json(food);
        }

        //載入飲食日誌
        public IActionResult getIntakeRecords(string date)
        {
            date = date.Replace("-", "");
            var intakeRecords = new CDiaryViewModel(db).CalorieIntakes.Where(c => c.FIntakeTime.Substring(0, 8) == date).Select(c=>new {
                fMeal=c.FMeal,
                fCalorieIntakeId = c.FCalorieIntakeId,
                fFoodName = db.TFoodCalories.FirstOrDefault(f=>f.FFoodId==c.FFoodId).FFoodName,
                fQuantity =c.FQuantity,
                fUnit = db.TFoodCalories.FirstOrDefault(f => f.FFoodId == c.FFoodId).FUnit,
                subtotal = db.TFoodCalories.FirstOrDefault(f => f.FFoodId == c.FFoodId).FCalories*c.FQuantity
            });
            return Json(intakeRecords);
        }

        //修改攝取數量
        public IActionResult editCalorieIntake(TCalorieIntake intake)
        {
            if (intake.FCalorieIntakeId != null && intake.FQuantity != null)
            {
                //TODO tryparse
                db.TCalorieIntakes.FirstOrDefault(c => c.FCalorieIntakeId == intake.FCalorieIntakeId).FQuantity = intake.FQuantity;
                db.SaveChanges();
            }
            return Content("finish", "text/plain", System.Text.Encoding.UTF8);
        }

        //刪除飲食紀錄
        public IActionResult delCalorieIntake(int FCalorieIntakeId)
        {
            if (FCalorieIntakeId != null)
            {
                //TODO tryparse
                var calorieIntakes = db.TCalorieIntakes.FirstOrDefault(c => c.FCalorieIntakeId == FCalorieIntakeId);
                db.TCalorieIntakes.Remove(calorieIntakes);
                db.SaveChanges();
            }
            return Content("finish", "text/plain", System.Text.Encoding.UTF8);
        }
    }
}
