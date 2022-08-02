﻿using Microsoft.AspNetCore.Mvc;
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
        //專欄表單生成，利用x.pagedlist套件和搜尋viewmodel
        public IActionResult List(CNewsViewModel vModel, int? page)
        {
            IHealthContext db = new IHealthContext();
            IPagedList<TNews> datas;

            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = db.TNews.Select(t => t).OrderBy(t => t.FNewsId).Include(t => t.FNewsCategory).Include(n => n.FMember)
                    .ToPagedList(page ?? 1, 5);
            }

            else
            {
                datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword)).Include(t => t.FNewsCategory).Include(n => n.FMember)
                    .ToPagedList(page ?? 1, 5);
            }

            ViewBag.OnePageOfNews = datas;
            return View(datas);
        }
        //專欄後台詳細內容顯示
        public IActionResult Details(int? id)
        {
            IHealthContext db = new IHealthContext();
            TNews news = db.TNews.FirstOrDefault(t => t.FNewsId == id);
            if (news == null)
                return RedirectToAction("List");
            return View(news);
        }
        //專欄新增，利用viewmodel存入圖檔至根目錄
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
        //專欄編輯，利用viewmodel帶過categoryname
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
        //專欄刪除
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

        //選取類別api，尚無法完成連動分頁
        public IActionResult SelectCategoryIDAPI(int id)
        {
            IHealthContext db = new IHealthContext();

            var selCateID = (from n in db.TNews
                             join c in db.TNewsCategories
                             on n.FNewsCategoryId equals c.FNewsCategoryId
                             where n.FNewsCategoryId == id
                             join m in db.TMembers
                             on n.FMemberId equals m.FMemberId
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
                                 newsCategory = n.FNewsCategory,
                                 getMember = n.FMember
                             }).ToList();

            return Json(selCateID);
        }
        //重置類別選項api
        public IActionResult ResetList()
        {
            IHealthContext db = new IHealthContext();
            var clickReset = (from n in db.TNews
                              join c in db.TNewsCategories
                              on n.FNewsCategoryId equals c.FNewsCategoryId
                              join m in db.TMembers
                              on n.FMemberId equals m.FMemberId
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
                                  newsCategory = n.FNewsCategory,
                                  getMember = n.FMember
                              }).ToList();

            return Json(clickReset);
        }
    }
}
