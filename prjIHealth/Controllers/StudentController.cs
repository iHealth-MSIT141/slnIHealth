using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjiHealth.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult CoachMainPage()    //教練專區主頁
        {
            return View();
        }
        public IActionResult CoachList()    //教練列表
        {
            return View();
        }
        public IActionResult ViewCoachDetails()     //教練詳細資料
        {
            return View();
        }                      
        public IActionResult CourseList()   //會員專區--課程列表
        {
            return View();
        }               
        public IActionResult CandidateList()    //會員專區--候選教練
        {
            return View();
        }
        public IActionResult ViewCourseCalendar()   //課程行事曆
        {
            return View();
        }       
        public IActionResult Index()
        {
            return View();
        }       
    }
}
