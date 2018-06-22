using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IUserInfo
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userInfo"></param>
        void AddUserInfo(UserInfo userInfo);
        //登陆      
        UserInfo Login(string UserName, string Password);
        /// <summary>
        /// 得到用户通过用户名
        /// </summary>
        /// <param name="UsersName"></param>
        /// <returns></returns>
        UserInfo GetUserName(string UsersName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UsersName"></param>
        /// <returns></returns>
        IEnumerable<UserInfo> IEGetUserName(string UsersName);
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userInfo"></param>
        void UpdateUserInfo(UserInfo userInfo);
        //显示用户的评论
    }
}
