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
    public class UserInfoManager
    {
        IUserInfo iuserinfo = DataAccess.CreateUserInfo();
        public void AddUserInfo(UserInfo userInfo)
        {
            iuserinfo.AddUserInfo(userInfo);
        }
        public IEnumerable<UserInfo> IEGetUserName(string UserName)
        {
            var userInfo = iuserinfo.IEGetUserName(UserName);
            return userInfo;
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public UserInfo Login(string UserName, string Password)
        {
            var userInfo = iuserinfo.Login(UserName, Password);
            return userInfo;
        }
        /// <summary>
        /// 通过用户名得到信息
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>

        public UserInfo GetUserName(string UserName)
        {
            var userInfo = iuserinfo.GetUserName(UserName);
            return userInfo;
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="userInfo"></param>
        public void UpdateUserInfo(UserInfo userInfo)
        {
            iuserinfo.UpdateUserInfo(userInfo);
        }
    }
}
