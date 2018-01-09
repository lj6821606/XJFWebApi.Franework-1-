using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XJFWeb_MVC.Controllers
{
    public class RoleController : Controller
    {
        /// <summary>
        /// 角色首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        public ActionResult AddRole()
        {
            return View();
        }
    }
}