using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Model;

namespace GY.Models
{
    public class NewsViewMode
    {
        //得到最新新闻
        public IEnumerable<News> GetNewNews { get; set; }
        //得到新闻
        public IEnumerable<News> News { get; set; }
        //展示前几
        public IQueryable<News> GetNewsbyTop { get; set; }
        //根据ID展示
        public News GetNewsById{ get; set; }
        public News news { get; set; }  //用来修改资料
        ////根据ID得到新闻
        //public IEnumerable<News> GetNewsById { get; set; }
        //public IEnumerable<News> MoviesTop5 { get; set; }
        //public IEnumerable<News> GetMoviesTpye { get; set; }
    }
}