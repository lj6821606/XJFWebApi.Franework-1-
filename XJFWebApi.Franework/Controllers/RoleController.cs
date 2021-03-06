﻿using Request.Models;
using System;
using System.Collections.Generic;
using System.IService;
using System.Linq;
using System.Models;
using System.Net;
using System.Net.Http;
using System.Service;
using System.Web.Http;

namespace XJFWebApi.Franework.Controllers
{
    /// <summary>
    /// 角色控制器
    /// </summary>
    public class RoleController : BaseApiController
    {
        IBaseIService<XJFRole> baseIService = new RoleService();
        /// <summary>
        /// 添加一条角色内容
        /// </summary>
        /// <param name="data">角色对象</param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult AddRole(XJFRole data)
        {
            try
            {
                var result = baseIService.AddFirst(data);
                return Ok<ReqsponsModels<XJFRole>>(result);
            }
            catch(Exception ex)
            {
                return Ok(ErrorMessage(ex));
            }
        }
        /// <summary>
        /// 分页获取对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetList(RequestPage<XJFRole> data)
        {
            var result = baseIService.GetList(data);
            return Ok<ReqsponsModels<List<XJFRole>>>(result);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult DelectFirst(string Id)
        {
            var result = baseIService.DelectFirst(Id);
            return Ok(result);
        }

        /// <summary>
        /// 根据id获取一条数据
        /// </summary>
        /// <param name="Id">id</param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetFirst(string Id)
        {
            var result = baseIService.GetFirst(Id);
            return Ok(result);
        }
    }
}
