using Model;
using System.Data.Entity.Validation;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GY.Controllers
{
    public class UserCenterController : Controller
    {
        UserInfoManager userinfomanager = new UserInfoManager();
        CommentsManager Com = new CommentsManager();
        ReCommentManager Recom = new ReCommentManager();
        GYEntities db = new GYEntities();
        // GET: UserCenter
        public ActionResult Index()
        {
            
            int User_id = Convert.ToInt32(Session["userid"]);

            //得到信息
            var userinfo = userinfomanager.IEGetUser(User_id);
            //我的评论
            var com = Com.GetNewsComById(User_id);
            //我的回复
            var recom = Recom.GetNewsReComById(User_id);
            return View(userinfo);
        }
        #region 修改个人信息        
        public ActionResult UserCenter1(UserInfo user)
        {
            UserInfo u = userinfomanager.IEGetUser(int.Parse(Session["UserID"].ToString()));
            HttpPostedFileBase photo = Request.Files["Photo"];
            try
            {
                //if (photo.FileName != "")
                //{
                //    string filePath = photo.FileName;
                //    string filename = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") +
                //                      filePath.Substring(filePath.LastIndexOf("\\") + 1);
                //    string serverpath = Server.MapPath(@"\images\UserTouXiang\") + filename;
                //    string relativepath = @"/images/UserTouXiang/" + filename;
                //    photo.SaveAs(serverpath);
                //    user.UserImage = relativepath;
                //}
                //else
                //{
                //    user.UserImage = db.UserInfo.Find(user.UserID).UserImage;
                //}
                //u.Sex = user.Sex;
                u.UserName = user.UserName;
                u.Email = user.Email;
                u.Password = user.Password;
                u.Phone = user.Phone;


                userinfomanager.UpdateUserInfo(u);
            }
            catch (DbEntityValidationException ex)
            {
                string error = ex.Message;

            }

            return View("Index", u);
        }
        #endregion

    }
}