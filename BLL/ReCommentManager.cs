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
     public class ReCommentManager
    {
        IReComment iReComments = DataAccess.CreateReComment();
        /// <summary>
        /// 得到新闻评论回复
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ReComment> GetNewsReCom()
        {
            var newrecomm = iReComments.GetNewsReCom();
            return newrecomm;
        }
        /// <summary>
        /// 根据ID得到新闻评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ReComment GetNewsReComById(int? id)
        {
            ReComment newRecom = iReComments.GetNewsReComById(id);
            return newRecom;
        }
    }
}
