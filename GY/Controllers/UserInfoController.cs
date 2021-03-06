﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Protocols;
using BLL;
using Model;
using GY.Models;

namespace GY.Controllers
{
    public class UserInfoController : Controller
    {
        UserInfoManager userinfomanager = new UserInfoManager();
        GYEntities db = new GYEntities();
         UserViewMode ucvm = new UserViewMode();
        //PostManager postManager = new PostManager();
        // GET: UserInfo
        //个人显示
        public ActionResult Index( )
        {
            //得到ID
           int userid =Convert.ToInt32(Session["UserID"].ToString());
            ucvm.user = db.UserInfo.Find(userid);

            //根据ID显示评论
            ucvm.viewcomment = userinfomanager.GetCommById(userid);
            //根据ID显示回复评论
            ucvm.vierecomment = userinfomanager.GetReCommById(userid);
            //根据ID显示个人资料
            //ucvm.viewUserInfo = userinfomanager.IEGetUser(userid);
            return View(ucvm);
        }
        #region 登录
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "UserName,Password")]string UserName, string Password)
        {
            try
            {
                var users = userinfomanager.Login(UserName, Password);
                if (users != null)
                {
                    //保存到Session HttpContext.
                    Session["UserName"] = UserName;
                    Session["UserID"] = users.UserID; //将用户名放入session中                    
                    return Content("<script>;alert('登录成功!返回首页!');window.location.href='/UserCenter/Index'</script>");
                }
                else
                {
                    //string data = "登录失败";
                    //return data;
                    return Content("<script>;alert('该账号不存在!');history.go(-1)</script>");
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        #endregion
        #region 注册
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register([Bind(Include = "UserName,Password,Email")] UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {               
                userinfomanager.AddUserInfo(userInfo);               
                return Content("<script>;alert('注册成功!进入首页!');window.location.href='/Index/Index'</script>");             
            }
            else
            {
                return Content("<script>;alert('注册失败！');history.go(-1)</script>");
            }
        }
        #endregion
        //#region 修改资料
    

        //public ActionResult Ziliao(UserInfo userInfo)
        //{
        //    UserInfo u = userinfomanager.IEGetUser(Convert.ToInt32(Session["Userid"].ToString()));
        //    //    HttpPostedFileBase userImage = Request.Files["UserImage"];
        //    try
        //    {
        //        //if (userImage.FileName != "")
        //        //{
        //        //    string filePath = userImage.FileName;
        //        //    string filename = DateTime.Now.ToString("yyyyMMddHHmmssfffffff") +
        //        //                      filePath.Substring(filePath.LastIndexOf("\\") + 1);
        //        //    string serverpath = Server.MapPath(@"\Images\userInfo\") + filename;
        //        //    string relativepath = @"/Images/userInfo/" + filename;
        //        //    userImage.SaveAs(serverpath);
        //        //    userInfo.UserImage = relativepath;
        //        //}
        //        //else
        //        //{
        //        //    userInfo.UserImage = db.UserInfo.Find(userInfo.UserID).UserImage;
        //        //}
        //        if (ModelState.IsValid)
        //        {
        //            //图片
        //            userInfo.UserImage = db.UserInfo.Find(userInfo.UserID).UserImage;
        //            //用户名
        //            userInfo.UserName = db.UserInfo.Find(userInfo.UserID).UserName;
        //            //密码
        //            userInfo.Password = db.UserInfo.Find(userInfo.UserID).Password;
        //            //邮箱
        //            userInfo.Email = db.UserInfo.Find(userInfo.UserID).Email;
        //            //手机号
        //            userInfo.Phone = db.UserInfo.Find(userInfo.UserID).Phone;
        //            //修改语句
        //            userinfomanager.UpdateUserInfo(userInfo);
        //            //db.Post.Add(post);
        //            //db.SaveChanges();
        //            //return RedirectToAction("Index");
        //            //return "aa";
        //            return RedirectToAction("Ziliao", "UserInfo");
        //            //return Content("<script>;alert('修改成功！');</script>");
        //        }
        //        else
        //        {
        //            //return "bb";
        //            return Content("<script>;alert('修改失败！');window.history.go(-1);window.location.reload();</script>");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //return ex.ToString();
        //        return Content(ex.Message);
        //    }
        //}
        //#endregion
        //#region 个人中心
       
        //#endregion
        #region 注销
        [HttpPost]
        public string Zhuxiao()
        {
            //保存到Session HttpContext.
            Session["UserName"] = null;
            string A = "a";
            return A;
        }
        #endregion
    }
}