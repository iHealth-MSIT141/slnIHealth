using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using X.PagedList;
using Microsoft.AspNetCore.Hosting;
using prjIHealth.Models;
using Microsoft.AspNetCore.Http;
using prjiHealth.ViewModels;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace prjIHealth.Areas.Admin.Controllers
{
    [Area(areaName: "Admin")]
    public class NewsManageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private IWebHostEnvironment _enviroment;
        public NewsManageController(IWebHostEnvironment n)
        {
            _enviroment = n;
        }
        //IHealthContext db = new IHealthContext();


        //public IActionResult List(CKeywordViewModel vModel)
        //{
        //    //int currentPage = vModel.page < 1 ? 1 : vModel.page;
        //    IHealthContext db = new IHealthContext();
        //    Trace.WriteLine(db.TMembers);

        //    var news = db.TMembers.OrderBy(n => n.FMemberId).ToList();

        //    return View(news);


        //IEnumerable<TNews> datas = null;
        //if (string.IsNullOrEmpty(vModel.txtKeyword))
        //{
        //    datas = from t in db.TNews
        //            select t;
        //    //data = db.TNews.OrderBy(t => t.FNewsId).ToList();
        //    //datas = db.TNews.ToPagedList(currentPage, pageListSize);
        //}
        //else
        //{
        //    datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword));
        //}
        //return View(datas);
        //}
        public IActionResult List(CNewsViewModel vModel, int? page)
        {
            //int currentPage = vModel.page < 1 ? 1 : vModel.page;
            IHealthContext db = new IHealthContext();
            //int currentPage = page < 1 ? 1 : page;
            var pageNumber = page ?? 1;
            // Trace.WriteLine(db.TNews);
            var news = db.TNews.OrderBy(n => n.FNewsId).ToList();
            var testNews = db.TNews.Include(t => t.FNewsCategory).ToList();
            var onePageOfNews = news.ToPagedList(pageNumber, 5);
            IEnumerable<TNews> datas = null;

            //CNewsViewModel vModel = new CNewsViewModel();

            //var news = db.TNews.OrderBy(n => n.FNewsId).Include(t => t.FNewsCategory).ToList();

            if (news != null)
            {
                if (string.IsNullOrEmpty(vModel.txtKeyword))
                {
                    datas = from t in db.TNews
                            select t;
                    onePageOfNews = datas.ToPagedList(pageNumber, 5);
                }
                else
                {
                    datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword));
                    onePageOfNews = datas.ToPagedList(pageNumber, 5);
                }

                ViewBag.OnePageOfNews = onePageOfNews;
                return View(onePageOfNews);
            }
            return View(news);
            //return View(datas.ToPagedList(currentPage.pageSize));
        }

        //public IActionResult Blog(CNewsViewModel vModel)
        //{
        //    //IHealthyContext db = new IHealthyContext();
        //    IEnumerable<TNews> datas = null;
        //    if (string.IsNullOrEmpty(vModel.txtKeyword))
        //    {
        //        datas = from t in db.TNews
        //                select t;
        //    }
        //    else
        //    {
        //        datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword));
        //    }
        //    return View(datas);
        //}

        //public IActionResult BlogDetail(int? id)
        //{
        //    TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
        //    if (news == null)
        //        return RedirectToAction("Blog");
        //    return View(news);
        //}

        public IActionResult Details(int? id)
        {
            IHealthContext db = new IHealthContext();
            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news == null)
                return RedirectToAction("List");
            return View(news);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CNewsViewModel vModel)
        {
            IHealthContext db = new IHealthContext();
            TNews news = new TNews();
            news.FTitle = vModel.FTitle;
            news.FContent = vModel.FContent;
            news.FNewsDate = vModel.FNewsDate;
            news.FNewsCategoryId = vModel.FNewsCategoryId;
            news.FVideoUrl = vModel.FVideoUrl;
            news.FViews = vModel.FViews;
            news.FMemberId = vModel.FMemberId;

            if (vModel.photo != null)
            {
                string nName = Guid.NewGuid().ToString() + ".jpg";
                vModel.photo.CopyTo(new FileStream(
                    _enviroment.WebRootPath + "/img/blog/" + nName, FileMode.Create));
                news.FThumbnailPath = nName;
            }
            db.Add(news);
            db.SaveChanges();

            return RedirectToAction("List");
        }

        public IActionResult Edit(int? id)
        {
            IHealthContext db = new IHealthContext();
            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news == null)
                return RedirectToAction("List");
            return View(news);
        }
        [HttpPost]
        public IActionResult Edit(CNewsViewModel n)
        {
            IHealthContext db = new IHealthContext();
            // foreach (var dbNew in db.TNews)
            // {
            //     Console.WriteLine(dbNew.FNewsId);
            //     Console.WriteLine(n.FNewsId);
            // }
            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == n.FNewsId);
            if (news != null)
            {
                if (n.photo != null)
                {
                    string nName = Guid.NewGuid().ToString() + ".jpg";
                    n.photo.CopyTo(new FileStream(
                        _enviroment.WebRootPath + "/img/blog/" + nName, FileMode.Create));
                    news.FThumbnailPath = nName;
                }
                news.FTitle = n.FTitle;
                news.FNewsDate = n.FNewsDate;
                news.FContent = n.FContent;
                news.FNewsCategoryId = n.FNewsCategoryId;
                news.FVideoUrl = n.FVideoUrl;
            }
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public IActionResult Delete(int? id)
        {
            IHealthContext db = new IHealthContext();
            var news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news != null)
            {
                db.TNews.Remove(news);
                db.SaveChanges();
            }
            return RedirectToAction("List");
        }

        //[HttpPost("FileUpload")]
        //public async Task<IActionResult> Index(List<IFormFile> files)
        //{
        //    long size = files.Sum(f => f.Length);

        //    var filePaths = new List<string>();
        //    foreach (var formFile in files)
        //    {
        //        if (formFile.Length > 0)
        //        {
        //            // full path to file in temp location
        //            var filePath = Path.GetTempFileName();
        //            filePaths.Add(filePath);

        //            using (var stream = new FileStream(filePath, FileMode.Create))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }
        //        }
        //    }
        //    // process uploaded files
        //    // Don't rely on or trust the FileName property without validation.
        //    return Ok(new { count = files.Count, size, filePaths });
        //}

        public IActionResult SelectCategoryIDAPI(int id)
        {
            IHealthContext db = new IHealthContext();

            //var selCatID = db.TNews.Where(n => n.FNewsCategoryId == id).Select(t => t);/*.Select(t => t.FNewsCategory.FNewsCategoryId)*/

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

            return Json(selCateID);
        }

        public IActionResult ResetList()
        {
            IHealthContext db = new IHealthContext();
            var clickReset = (from n in db.TNews
                              join c in db.TNewsCategories
                              on n.FNewsCategoryId equals c.FNewsCategoryId
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

            return Json(clickReset);
        }
    }
}
