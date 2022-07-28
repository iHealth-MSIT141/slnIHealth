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
using prjIHealth.ViewModels;
using System.Text.Json;
using prjiHealth.Models;
using Microsoft.AspNetCore.Http;

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

            var pageNumber = page ?? 1;
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
                    datas = (from t in db.TNews
                             select t).Include(c => c.TNewsComments);
                    onePageOfBlogs = datas.ToPagedList(pageNumber, 6);
                }
                else
                {
                    datas = db.TNews.Where(t => t.FTitle.Contains(vModel.txtKeyword)).Include(c => c.TNewsComments);
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
            //var news = db.TMembers.Include(n=>n.TNews).FirstOrDefault(t=>t.)
            if (news == null)
                return RedirectToAction("Blog");

            return View(news);
        }
        [HttpPost]
        public IActionResult ReplyComment(TNewsComment comment)
        {
            IHealthContext db = new IHealthContext();
            int userID = TakeMemberID();
            TNewsComment newsComment = new TNewsComment()
            {
                FMemberId = userID,
                FNewsReply = comment.FNewsReply,
                FNewsId = comment.FNewsId
            };
            if (userID == 0)
            {
                newsComment.FMemberId = comment.FMemberId;
            }
            else
            {
                newsComment.FMemberId = userID;
            }

            db.TNewsComments.Add(newsComment);
            db.SaveChanges();
            return RedirectToAction("BlogDetail", "News", new { id = comment.FNewsId });

            return RedirectToAction("BlogDetail", "News", new { id = comment.FNewsId });
            //return Content("謝謝你哦", "text/plain", System.Text.Encoding.UTF8);
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
            }
            return Json(selCateID);
        }

        public IActionResult LoadComment(int id)
        {
            IHealthContext db = new IHealthContext();
            var comment = db.TNewsComments.Where(t => t.FNewsId == id).OrderByDescending(m => m.FNewsCommentId)
                .Select(vModel => new CNewsCommentViewModel()
                {
                    FMemberId = vModel.FMemberId,
                    FNewsId = vModel.FNewsId,
                    FNewsReply = vModel.FNewsReply,
                    MemberName = vModel.FMember,
                    FNewsCommentId = vModel.FNewsCommentId
                }).ToList();
            var commentCount = db.TNewsComments.Where(t => t.FNewsId == id).OrderByDescending(m => m.FNewsCommentId)
           .Select(vModel => new CNewsCommentViewModel()
           {
               FMemberId = vModel.FMemberId,
               FNewsId = vModel.FNewsId,
               FNewsReply = vModel.FNewsReply,
               MemberName = vModel.FMember,
               FNewsCommentId = vModel.FNewsCommentId
           }).Count();
            ViewBag.CommentCount = commentCount;
            return PartialView(comment);
        }

        public IActionResult CommentAPI(int? id)
        {
            IHealthContext db = new IHealthContext();
            var comment = db.TNewsComments.Where(t => t.FNewsId == id).Select(vModel => new CNewsCommentViewModel()
            {
                FMemberId = vModel.FMemberId,
                FNewsId = vModel.FNewsId,
                FNewsReply = vModel.FNewsReply,
                MemberName = vModel.FMember
            }).ToList();
            return Json(comment);
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

        //public IActionResult CommentCount(int? id)
        //{
        //    IHealthContext db = new IHealthContext();
        //    IEnumerable<TNewsComment> newsComments = null;
        //    int q=0;
        //    if (id == null)
        //    {
        //        newsComments = from t in db.TNewsComments
        //                       select t;
        //        q = newsComments.Count();
        //    }
        //    if (id != null)
        //    {
        //        newsComments = from t in db.TNewsComments
        //                       where t.FNewsId == id
        //                       select t;
        //        q = newsComments.Count();
        //    }
        //    return Json(q);
        //}
    }
}
