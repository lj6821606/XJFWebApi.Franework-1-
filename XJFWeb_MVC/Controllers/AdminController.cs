using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XJFWeb_MVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 管理员添加
        /// </summary>
        /// <returns></returns>
        public ActionResult AddAdmin()
        {
            return View();
        }
    }
}