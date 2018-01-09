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
    /// 菜单表逻辑表
    /// </summary>
    public class XJFMenuService : IBaseIService<XJFMenu>
    {
    	IBaseIDAO<XJFMenu> XJFMenuDAO = new XJFMenuDAO();
    	
    	/// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        ReqsponsModels<XJFMenu> IBaseIService<XJFMenu>.AddFirst(XJFMenu data)
        {
            ReqsponsModels<XJFMenu> reqsponsModels = new ReqsponsModels<XJFMenu>();
           	//验证信息
           	
           	//
            data.XJFMenuID = Guid.NewGuid().ToString();
            data.XJFCreateTime = DateTime.Now;
            data.XJFStatu = true;
            var result =XJFMenuDAO.AddFirst(data);

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
        ReqsponsModels<string> IBaseIService<XJFMenu>.DelectFirst(string Id)
        {
            ReqsponsModels<string> reqsponsModels = new ReqsponsModels<string>();
            var result = XJFMenuDAO.DelectFirst(Id);
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
        ReqsponsModels< XJFMenu> IBaseIService<XJFMenu>.GetFirst(string Id)
        {
            ReqsponsModels<XJFMenu> reqsponsModels = new ReqsponsModels<XJFMenu>();
            var result = XJFMenuDAO.GetFirst(Id);
            reqsponsModels.Data = result;
            return reqsponsModels;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">条件</param>
        /// <returns></returns>
        ReqsponsModels<List<XJFMenu>> IBaseIService<XJFMenu>.GetList(RequestPage<XJFMenu> data)
        {
            ReqsponsModels<List<XJFMenu>> reqsponsModels = new ReqsponsModels<List<XJFMenu>>();
            reqsponsModels.Data = XJFMenuDAO.GetList(data);
            reqsponsModels.Code = "200";
            reqsponsModels.CodeInfo = "操作成功！";
            return reqsponsModels;
        }
    }
}