using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using prjIHealth.Models;
using prjiHealth.ViewModels;
using X.PagedList;
using Microsoft.EntityFrameworkCore;

namespace prjiHealth.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IWebHostEnvironment _enviroment;
        public NewsController(IWebHostEnvironment n)
        {
            _enviroment = n;
        }

        public IActionResult Blog(CNewsViewModel vModel, int? page)
        {
            IHealthContext db = new IHealthContext();

            //IHealthyContext db = new IHealthyContext();
            var pageNumber = page ?? 1;
            //Trace.WriteLine(db.TNews);
            var news = db.TNews.OrderBy(n => n.FNewsId).ToList();
            var testNews = db.TNews.Include(t => t.FNewsCategory).ToList();
            var onePageOfBlogs = news.ToPagedList(pageNumber, 6);
            var category0Count = db.TNews.Select(t => t).Count();
            ViewBag.Category0Count = category0Count;
            var category1Count = db.TNews.Where(t => t.FNewsCategoryId == 1).Count();
            ViewBag.Category1Count = category1Count;
            var category2Count = db.TNews.Where(t => t.FNewsCategoryId == 2).Count();
            ViewBag.Category2Count = category2Count;
            var category3Count = db.TNews.Where(t => t.FNewsCategoryId == 3).Count();
            ViewBag.Category3Count = category3Count;
            var category4Count = db.TNews.Where(t => t.FNewsCategoryId == 4).Count();
            ViewBag.Category4Count = category4Count;

            IEnumerable<TNews> datas = null;
            if (news != null)
            {
                if (string.IsNullOrEmpty(vModel.txtKeyword))
                {
                    datas = from t in db.TNews
                            select t;
                    onePageOfBlogs = datas.ToPagedList(pageNumber, 6);
                }
                else
                {
                    datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword));
                    onePageOfBlogs = datas.ToPagedList(pageNumber, 6);
                }
                ViewBag.onePageOfBlogs = onePageOfBlogs;
                return View(onePageOfBlogs);
            }
            return View(onePageOfBlogs);
        }

        public IActionResult BlogCategory(int? id)
        {
            IHealthContext db = new IHealthContext();
            var selCateID = (from n in db.TNews
                             join c in db.TNewsCategories
                             on n.FNewsCategoryId equals c.FNewsCategoryId
                             where n.FNewsCategoryId == id
                             select new CNewsViewModel()
                             {
                                 FNewsId = n.FNewsId,
                                 FTitle = n.FTitle,
                                 FNewsDate = n.FNewsDate,
                                 FContent = n.FContent,
                                 FThumbnailPath = n.FThumbnailPath,
                                 FNewsCategoryId = n.FNewsCategoryId,
                                 FViews = n.FViews,
                                 FVideoUrl = n.FVideoUrl,
                                 FMemberId = n.FMemberId,
                                 newsCategory = n.FNewsCategory
                             }).ToList();
            return View(selCateID);
        }

        public IActionResult BlogDetail(int? id)
        {
            IHealthContext db = new IHealthContext();

            var category0Count = db.TNews.Select(t => t).Count();
            ViewBag.Category0Count = category0Count;
            var category1Count = db.TNews.Where(t => t.FNewsCategoryId == 1).Count();
            ViewBag.Category1Count = category1Count;
            var category2Count = db.TNews.Where(t => t.FNewsCategoryId == 2).Count();
            ViewBag.Category2Count = category2Count;
            var category3Count = db.TNews.Where(t => t.FNewsCategoryId == 3).Count();
            ViewBag.Category3Count = category3Count;
            var category4Count = db.TNews.Where(t => t.FNewsCategoryId == 4).Count();
            ViewBag.Category4Count = category4Count;

            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news == null)
                return RedirectToAction("Blog");
            return View(news);
        }

        public IActionResult BlogSelectCategoryAPI(int? id)
        {
            IHealthContext db = new IHealthContext();
            IEnumerable<TNews> selCateID = null;
            if (id == null)
            {
                selCateID = from t in db.TNews
                            orderby t.FNewsId
                            select t;
            }
            if (id != null)
            {
                selCateID = from t in db.TNews
                            where t.FNewsCategoryId == id
                            orderby t.FNewsId
                            select t;
                //var selCateID = (from n in db.TNews
                //                 join c in db.TNewsCategories
                //                 on n.FNewsCategoryId equals c.FNewsCategoryId
                //                 where n.FNewsCategoryId == id
                //                 select new CNewsViewModel()
                //                 {
                //                     FNewsId = n.FNewsId,
                //                     FTitle = n.FTitle,
                //                     FNewsDate = n.FNewsDate,
                //                     FContent = n.FContent,
                //                     FThumbnailPath = n.FThumbnailPath,
                //                     FNewsCategoryId = n.FNewsCategoryId,
                //                     FViews = n.FViews,
                //                     FVideoUrl = n.FVideoUrl,
                //                     FMemberId = n.FMemberId,
                //                     newsCategory = n.FNewsCategory
                //                 }).ToList();
            }
            return Json(selCateID);
        }
    }
}
