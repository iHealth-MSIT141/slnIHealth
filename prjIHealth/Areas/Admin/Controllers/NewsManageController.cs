using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Microsoft.AspNetCore.Hosting;
using prjIHealth.Models;
using Microsoft.AspNetCore.Http;
using prjiHealth.ViewModels;
using System.Diagnostics;

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
        int pageBlogSize = 6;
        int pageListSize = 3;
        public IActionResult List(int page = 1)
        {
            //int currentPage = vModel.page < 1 ? 1 : vModel.page;
            IHealthContext db = new IHealthContext();
            int currentPage = page < 1 ? 1 : page;
            // Trace.WriteLine(db.TNews);
            var news = db.TNews.OrderBy(n => n.FNewsId).ToList();
            if (news != null)
            {
                var result = news.ToPagedList(currentPage, pageListSize);
                return View(result);
            }
            return View();
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
        public IActionResult Create(CNewsViewModel news)
        {
            IHealthContext db = new IHealthContext();
            TNews neew = new TNews();
            neew.FTitle = news.FTitle;
            neew.FContent = news.FContent;
            neew.FNewsDate = news.FNewsDate;
            neew.FNewsCategoryId = news.FNewsCategoryId;
            neew.FVideoUrl = news.FVideoUrl;
            neew.FViews = news.FViews;
            neew.FMemberId = news.FMemberId;

            if (news.photo != null)
            {
                string nName = Guid.NewGuid().ToString() + ".jpg";
                news.photo.CopyTo(new FileStream(
                    _enviroment.WebRootPath + "/img/blog/" + nName, FileMode.Create));
                neew.FThumbnailPath = nName;
            }
            db.Add(neew);
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

        [HttpPost("FileUpload")]
        public async Task<IActionResult> Index(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            var filePaths = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.GetTempFileName();
                    filePaths.Add(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            // process uploaded files
            // Don't rely on or trust the FileName property without validation.
            return Ok(new { count = files.Count, size, filePaths });
        }
    }
}
