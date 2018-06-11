using BLL;
using GY.Models;
using Model;using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GY.Controllers
{
    public class NewsDateilController : Controller
    {
        /// <summary>
        /// 实例化
        /// </summary>
        GYEntities db = new GYEntities();
        NewsManager mv = new NewsManager();
        CommentsManager newsd = new CommentsManager();
        // GET: NewsDateil
        #region 新闻详情页
        public ActionResult Index()
        {
            return View();
        }
        //根据ID展示

        //展示前6
        public ActionResult Article6()
        {
            var article6 = mv.GetNewsbyTop(6);
            return View(article6);
        }
        //根据ID来展现
        public ActionResult ArticleDetails(int id)
        {
            Session["nid"] = id;
            int n_id = Convert.ToInt32(Session["nid"]);
            var news = mv.GetNewsById(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(news);
        }
        #endregion


        #region 文章评论回复
        [HttpPost]
        [ValidateInput(false)]
        //[Login]
        public ActionResult Coms(Comments newsCom)
        {

            int aid = Convert.ToInt32(Session["aid"]);
            int userid = Convert.ToInt32(Session["UserID"]);
            string textarea = Request["pingluntextarea"];
            if (ModelState.IsValid)
            {
                if (textarea != "")
                {
                    newsCom.UserID = userid;
                    //新闻ID
                    newsCom.ThemeID = aid;
                    newsCom.ComTime = System.DateTime.Now;
                    //评论内容
                    newsCom.ComContent = textarea;
                    //增加评论
                    newsd.AddNewsCom(newsCom);
                }
                else
                {
                    return Content("<script>alert('评论不能为空！');history.go(-1)</script>");
                }
            }
            return RedirectToAction("ArticleDetails", "ArticleShow", new { id = aid });
        }
        public ActionResult ReplyArticleComments()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ReplyArticleComments(int ArticleComID, ArticleReply replya)
        {
            int aid = Convert.ToInt32(Session["aid"]);
            string replytext = Request.Form["textarea1"];
            if (replytext == "")
            {
                return Content("<script>;alert('回复不能为空');history.go(-1)</script>");
            }
            else
            {
                int userid = Convert.ToInt32(Session["UserID"]);
                replya.ArticleComID = ArticleComID;
                replya.UserID = userid;
                replya.ReplyContent = replytext;
                replya.ReplyTime = DateTime.Now;
                articlereplymanager.AddArticleReply(replya);

            }
            return RedirectToAction("ArticleDetails", "ArticleShow", new { id = aid });
        }
        #endregion

    }
}