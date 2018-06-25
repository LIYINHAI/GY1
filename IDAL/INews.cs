using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface INews
    {
        //得到新闻
        IEnumerable<News> GetNews();
        //根据ID得到新闻
        News GetNewsById(int? id);
        //删除新闻
        void RemoveNews(News news);
        //增加新闻
        void AddNews(News news);
        //得到最新的新闻
        IEnumerable<News> GetNewNews();
        //展示前几
        IQueryable<News> GetNewsbyTop(int top);
    }
}
