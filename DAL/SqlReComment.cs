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
    public class SqlReComment : IReComment
    {
        GYEntities db = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 得到新闻评论回复
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReComment> GetNewsReCom()
        {
            var recomments = db.ReComment.ToList();
            return recomments;
        }
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReComment GetNewsReComById(int? id)
        {
            ReComment recomments= db.ReComment.Find(id);
            return recomments;
        }
    }
}
