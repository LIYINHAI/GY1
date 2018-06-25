using BLL;
using GY.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GY.Controllers
{
    public class NewsController : Controller
    {
        GYEntities db = new GYEntities();
        NewsManager mv = new NewsManager();
        // GET: News
        public ActionResult Index()
        {
            NewsViewMode nvmd = new NewsViewMode();
            //得到新闻
            var getnew = mv.GetNews();
            nvmd.GetNews = getnew;
            //得到最新新闻
            var getnnew = mv.GetNewNews();
            nvmd.GetNewNews = getnnew;
            //得到前6的新闻
            var gettop6 = mv.GetNewsbyTop(6);
            nvmd.GetNewsbyTop = gettop6;
            return View(nvmd);
        }
    }
}