using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Model;
namespace GY.Models
{
    public class UserViewMode
    {
        public IEnumerable<Comments> viewcomment { get; set; }
        public IEnumerable<ReComment> vierecomment { get; set; }
        public IEnumerable<UserInfo> viewUserInfo{ get; set; }
    }
}