using System;
using System.Collections.Generic;
using System.DAO;
using System.IDAO;
using System.IService;
using System.Linq;
using System.Models;
using System.Text;
using System.Threading.Tasks;
using Request.Models;

namespace System.Service
{
    /// <summary>
    /// 角色逻辑表
    /// </summary>
    public class RoleService : IBaseIService<XJFRole>
    {
        IBaseIDAO<XJFRole> roleDAO = new XJFRoleDAO();
        /// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        ReqsponsModels<XJFRole> IBaseIService<XJFRole>.AddFirst(XJFRole data)
        {
            ReqsponsModels<XJFRole> reqsponsModels = new ReqsponsModels<XJFRole>();
            if (string.IsNullOrEmpty(data.XJFRoleName))
            {
                reqsponsModels = new ReqsponsModels<XJFRole>("3", "角色名称未输入!");
                return reqsponsModels;
            }
            data.XJFRoleID = Guid.NewGuid().ToString();
            data.XJFCreateTime = DateTime.Now;
            data.XJFStatu = true;
            var result = roleDAO.AddFirst(data);

            if (result.Result > 0)
            {
                reqsponsModels.Data = data;
            }
            else
            {
                reqsponsModels.Code = "301";
                reqsponsModels.CodeInfo = "新增操作失败";
                reqsponsModels.Data = null;
            }
            return reqsponsModels;
        }

        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        ReqsponsModels<string> IBaseIService<XJFRole>.DelectFirst(string Id)
        {
            ReqsponsModels<string> reqsponsModels = new ReqsponsModels<string>();
            var result = roleDAO.DelectFirst(Id);
            if (result.Result > 0)
            {
                reqsponsModels.Code = "200";
                reqsponsModels.CodeInfo = "操作成功！";
            }
            else
            {
                reqsponsModels.Code = "101";
                reqsponsModels.CodeInfo = "删除角色内容失败！";
            }
            reqsponsModels.Data = result.Result.ToString();
            return reqsponsModels;
        }

        /// <summary>
        /// 根据ID查询一条信息 
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        ReqsponsModels< XJFRole> IBaseIService<XJFRole>.GetFirst(string Id)
        {
            ReqsponsModels<XJFRole> reqsponsModels = new ReqsponsModels<XJFRole>();
            var result = roleDAO.GetFirst(Id);
            reqsponsModels.Data = result;
            return reqsponsModels;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">条件</param>
        /// <returns></returns>
        ReqsponsModels<List<XJFRole>> IBaseIService<XJFRole>.GetList(RequestPage<XJFRole> data)
        {
            ReqsponsModels<List<XJFRole>> reqsponsModels = new ReqsponsModels<List<XJFRole>>();
            reqsponsModels.Data = roleDAO.GetList(data);
            reqsponsModels.Code = "200";
            reqsponsModels.CodeInfo = "操作成功！";
            return reqsponsModels;
        }
    }
}
