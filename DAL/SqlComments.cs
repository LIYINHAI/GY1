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
    public class SqlComments : IComments
    {
        GYEntities db = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 增加新闻评论
        /// </summary>
        /// <param name="newsCom"></param>
        public void AddNewsCom(Comments newsCom)
        {
            db.Comments.Add(newsCom);
            db.SaveChanges();
        }
        /// <summary>
        /// 得到新闻评论
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Comments> GetNewsCom()
        {
            var comments = db.Comments.ToList();
            return comments;
        }
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Comments GetNewsComById(int? id)
        {
            Comments comments = db.Comments.Find(id);
            return comments;
        }
    }
}
