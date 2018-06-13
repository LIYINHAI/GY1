using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IReComment
    {
        /// <summary>
        /// 得到新闻评论回复
        /// </summary>
        /// <returns></returns>
        IEnumerable<ReComment> GetNewsReCom();
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ReComment GetNewsReComById(int? id);
        /// <summary>
        /// 评论
        /// </summary>
        /// <param name="newsCom"></param>
        //void AddNewsReCom(ReComment newsReCom);
    }
}
