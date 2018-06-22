using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Model;

namespace DAL
{
     public class SqlUserInfo:IUserInfo
    {
         GYEntities db = DbContextFactory.CreateDbContext();
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userInfo"></param>
         public void AddUserInfo(UserInfo userInfo)
         {
             db.UserInfo.Add(userInfo);
             db.SaveChanges();
         }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="userInfo"></param>
         public void UpdateUserInfo(UserInfo userInfo)
         {
             db.Entry(userInfo).State = EntityState.Modified;
             db.SaveChanges();
         }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
         public UserInfo Login(string UserName, string Password)
         {
             var userInfo = db.UserInfo.Where(u => u.UserName == UserName)
                 .Where(u => u.Password == Password).FirstOrDefault();
             return userInfo;
         }
        /// <summary>
        /// 通过用户名展现用户
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
         public UserInfo GetUserName(string UserName)
         {
             UserInfo userInfo = db.UserInfo.Find(UserName);
             return userInfo;
         }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
         public IEnumerable<UserInfo> IEGetUserName(string UserName)
         {
             var userInfo = db.UserInfo.Where(c => c.UserName == UserName);
             return userInfo;
         }
        /// <summary>
        /// 根据ID得到评论
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Comments GetCommById(int? id)
        {
            
        }
    }
}
