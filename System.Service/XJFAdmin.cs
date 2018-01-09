using System.Collections.Generic;
using System.DAO;
using System.IDAO;
using System.IService;
using System.Models;
using System.Text;
using System.Threading.Tasks;
using Encryption;
using Request.Models;

namespace System.Service
{
    /// <summary>
    /// 后台用戶表逻辑表
    /// </summary>
    public class XJFAdminService : IBaseIService<XJFAdmin>
    {
        XJFAdminDAO dao = new XJFAdminDAO();
        IBaseIDAO<XJFAdmin> XJFAdminDAO = new XJFAdminDAO();

        /// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        ReqsponsModels<XJFAdmin> IBaseIService<XJFAdmin>.AddFirst(XJFAdmin data)
        {
            ReqsponsModels<XJFAdmin> reqsponsModels = new ReqsponsModels<XJFAdmin>();
            //验证信息
            if (string.IsNullOrEmpty(data.XJFAdminPhone))
            {
                reqsponsModels = new ReqsponsModels<XJFAdmin>("3", "请输入手机号码!");
                return reqsponsModels;
            }
            if (string.IsNullOrEmpty(data.XJFAdminLgoinName))
            {
                reqsponsModels = new ReqsponsModels<XJFAdmin>("3", "请输入登录名!");
                return reqsponsModels;
            }

            if (dao.ExitAdmin(data) != null)
            {
                reqsponsModels = new ReqsponsModels<XJFAdmin>()
                {
                    Code = "1003",
                    CodeInfo = "账户已注册",
                    Data = null
                };
                return reqsponsModels;
            }

            data.XJFAdminPassWord = MD5Helper.GetMD5String(data.XJFAdminPassWord);
            data.XJFAdminID = Guid.NewGuid().ToString();
            data.XJFCreateTime = DateTime.Now;
            data.XJFStatu = true;
            var result = XJFAdminDAO.AddFirst(data);

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
        ReqsponsModels<string> IBaseIService<XJFAdmin>.DelectFirst(string Id)
        {
            ReqsponsModels<string> reqsponsModels = new ReqsponsModels<string>();
            var result = XJFAdminDAO.DelectFirst(Id);
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
        ReqsponsModels<XJFAdmin> IBaseIService<XJFAdmin>.GetFirst(string Id)
        {
            ReqsponsModels<XJFAdmin> reqsponsModels = new ReqsponsModels<XJFAdmin>();
            var result = XJFAdminDAO.GetFirst(Id);
            reqsponsModels.Data = result;
            return reqsponsModels;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">条件</param>
        /// <returns></returns>
        ReqsponsModels<List<XJFAdmin>> IBaseIService<XJFAdmin>.GetList(RequestPage<XJFAdmin> data)
        {
            ReqsponsModels<List<XJFAdmin>> reqsponsModels = new ReqsponsModels<List<XJFAdmin>>();
            reqsponsModels.Data = XJFAdminDAO.GetList(data);
            reqsponsModels.Code = "200";
            reqsponsModels.CodeInfo = "操作成功！";
            return reqsponsModels;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        ReqsponsModels<XJFAdmin> Login(LoginModel loginModel)
        {
            ReqsponsModels<XJFAdmin> reqsponsModels = new ReqsponsModels<XJFAdmin>();
            var result = dao.Login(loginModel.Loginname);
            if (result == null)
            {
                reqsponsModels = new ReqsponsModels<XJFAdmin>("1002", "请输入正确email/手机/登录名");
                return reqsponsModels;
            }
            loginModel.Password = MD5Helper.GetMD5String(loginModel.Password);
            if (!loginModel.Password.Equals(result.XJFAdminPassWord))
            {
                reqsponsModels = new ReqsponsModels<XJFAdmin>("1002", "登录密码或账户错误");
                return reqsponsModels;
            }
            //用户登录成功

            return null;
        }
    }
}