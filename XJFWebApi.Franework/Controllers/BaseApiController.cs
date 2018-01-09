using Request.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace XJFWebApi.Franework.Controllers
{
    /// <summary>
    /// 控制器父类
    /// </summary>
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 错误输出
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public ReqsponsModels<string> ErrorMessage(Exception ex)
        {
            ReqsponsModels<string> reqsponsModels = new ReqsponsModels<string>
            {
                Code = "109",
                CodeInfo = "服务器异常！请稍候再试！",
                Data = ex.ToString()
            };
            return reqsponsModels;
        }
        //protected override void Initialize(HttpControllerContext controllerContext)
        //{
        //    base.Initialize(controllerContext);
        //}
    }
}
