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
        public IEnumerable<News> News1 { get; set; }
        //根据ID得到新闻
        public IEnumerable<News> GetNewsById { get; set; }
        public IEnumerable<News> MoviesTop5 { get; set; }
        public IEnumerable<News> GetMoviesTpye { get; set; }
    }
}