using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using System.Data.Entity;


namespace DAL
{
    public class SqlNews : INews
    {
        GYEntities db = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="news"></param>
        public void AddNews(News news)
        {
            db.News.Add(news);
            db.SaveChanges();
        }
        /// <summary>
        /// 最新的新闻
        /// </summary>
        /// <returns></returns>

        public IEnumerable<News> GetNewNews()
        {
            var news = from ns in db.News
                           orderby ns.NewsTime descending
                           select ns;
            return news;
        }

        /// <summary>
        /// 得到新闻
        /// </summary>
        /// <returns></returns>
        public IEnumerable<News> GetNews()
        {
            var news = db.News.ToList();
            return news;
        }
        /// <summary>
        /// 根据ID得到新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<News> GetNewsById(int? id)
        {
            var news = from ni in db.News
                        where ni.NewsID == id
                        select ni;
            return news;
        }
        //删除新闻
        public void RemoveNews(News news)
        {
            db.News.Remove(news);
            db.SaveChanges();
        }
       
    }
}
