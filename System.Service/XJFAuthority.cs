using System.Collections.Generic;
using System.DAO;
using System.IDAO;
using System.IService;
using System.Models;
using System.Text;
using System.Threading.Tasks;
using Request.Models;

namespace System.Service
{
	/// <summary>
    /// 后台权限表逻辑表
    /// </summary>
    public class XJFAuthorityService : IBaseIService<XJFAuthority>
    {
    	IBaseIDAO<XJFAuthority> XJFAuthorityDAO = new XJFAuthorityDAO();
    	
    	/// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        ReqsponsModels<XJFAuthority> IBaseIService<XJFAuthority>.AddFirst(XJFAuthority data)
        {
            ReqsponsModels<XJFAuthority> reqsponsModels = new ReqsponsModels<XJFAuthority>();
            //验证信息
            return null;
           	//
            //data.XJFAuthorityID = Guid.NewGuid().ToString();
            //data.XJFCreateTime = DateTime.Now;
            //data.XJFStatu = true;
            var result =XJFAuthorityDAO.AddFirst(data);

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
        ReqsponsModels<string> IBaseIService<XJFAuthority>.DelectFirst(string Id)
        {
            ReqsponsModels<string> reqsponsModels = new ReqsponsModels<string>();
            var result = XJFAuthorityDAO.DelectFirst(Id);
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
        ReqsponsModels< XJFAuthority> IBaseIService<XJFAuthority>.GetFirst(string Id)
        {
            ReqsponsModels<XJFAuthority> reqsponsModels = new ReqsponsModels<XJFAuthority>();
            var result = XJFAuthorityDAO.GetFirst(Id);
            reqsponsModels.Data = result;
            return reqsponsModels;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">条件</param>
        /// <returns></returns>
        ReqsponsModels<List<XJFAuthority>> IBaseIService<XJFAuthority>.GetList(RequestPage<XJFAuthority> data)
        {
            ReqsponsModels<List<XJFAuthority>> reqsponsModels = new ReqsponsModels<List<XJFAuthority>>();
            reqsponsModels.Data = XJFAuthorityDAO.GetList(data);
            reqsponsModels.Code = "200";
            reqsponsModels.CodeInfo = "操作成功！";
            return reqsponsModels;
        }
    }
}