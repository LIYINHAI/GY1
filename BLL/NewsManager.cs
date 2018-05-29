using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDAL;
using DALFactory;

namespace BLL
{
     public class NewsManager
    {
        INews inews = DataAccess.CreateNews();
        /// <summary>
        /// 增加新闻
        /// </summary>
        /// <param name="news"></param>
        public void AddNews(News news)
        {
            inews.AddNews(news);
        }
        /// <summary>
        /// 最新的新闻
        /// </summary>
        /// <returns></returns>

        public IEnumerable<News> GetNewNews()
        {
            var getnewnews = inews.GetNewNews();
            return getnewnews;
        }
        /// <summary>
        /// 得到新闻
        /// </summary>
        /// <returns></returns>
        public IEnumerable<News> GetNews()
        {
            var news = inews.GetNews();
            return news;
        }
        /// <summary>
        /// 根据ID得到新闻
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<News> GetNewsById(int? id)
        {
            var getNewsById = inews.GetNewsById(id);
            return getNewsById;
        }
        /// <summary>
        /// 删除新闻
        /// </summary>
        /// <param name="news"></param>
        public void RemoveNews(News news)
        {
            inews.RemoveNews(news);
        }
    }
}
