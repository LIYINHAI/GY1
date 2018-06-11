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
    public class CommentsManager
    {
        IComments iComments = DataAccess.CreateComments();
        /// <summary>
        /// 增加新闻评论
        /// </summary>
        /// <param name="newsCom"></param>
        public void AddNewsCom(Comments newsCom)
        {
            iComments.AddNewsCom(newsCom);
        }
        /// <summary>
        /// 得到新闻评论
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Comments> GetNewsCom()
        {
            var newsCom = iComments.GetNewsCom();
            return newsCom;
        }
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Comments GetNewsComById(int? id)
        {
            Comments NnewsCom = iComments.GetNewsComById(id);
            return NnewsCom;
        }
    }
}
