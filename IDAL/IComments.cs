using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IComments
    {
        /// <summary>
        /// 得到新闻评论
        /// </summary>
        /// <returns></returns>
        IEnumerable<Comments> GetNewsCom();
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Comments GetNewsComById(int? id);
       /// <summary>
       /// 增加新闻评论
       /// </summary>
       /// <param name="newsCom"></param>
        void AddNewsCom(Comments newsCom);
    }
}
