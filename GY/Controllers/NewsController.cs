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
        NewsViewMode newsviewmode = new NewsViewMode();
        // GET: News
        public ActionResult Index()
        {

           // newsviewmode.news = mv.GetNewNews();      
            //得到新闻
            newsviewmode.News1 = mv.GetNews();
            //得到最新的新闻
            newsviewmode.GetNewNews = mv.GetNewNews().Take(6);
            //根据ID得到新闻
            //newsviewmode.GetNewsById = mv.GetNewsById(id);
            return View(newsviewmode);
        }
    }
}