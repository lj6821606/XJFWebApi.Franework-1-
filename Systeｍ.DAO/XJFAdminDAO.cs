using Request.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IDAO;
using System.Linq;
using System.Models;
using System.Text;
using System.Threading.Tasks;

namespace System.DAO
{
	 public class XJFAdminDAO : Base_System, IBaseIDAO<XJFAdmin>
	 {
	 	/// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFAdmin>.AddFirst(XJFAdmin data)
        {
            messageEntities.XJFAdmin.Add(data);
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFAdmin>.DelectFirst(string Id)
        {
            var data = messageEntities.XJFAdmin.First(e => e.XJFAdminID == Id);
            data.XJFStatu = false;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 修改一条数据对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> IBaseIDAO<XJFAdmin>.UpdateFirst(XJFAdmin data)
        {
            messageEntities.Entry<XJFAdmin>(data).State = Data.Entity.EntityState.Modified;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 根据ID查询一条信息
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        XJFAdmin IBaseIDAO<XJFAdmin>.GetFirst(string Id)
        {
            var result = messageEntities.XJFAdmin.FirstOrDefault(e => e.XJFAdminID == Id);
            return result;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">分页对象</param>
        /// <returns>list 集合对象</returns>
        List<XJFAdmin> IBaseIDAO<XJFAdmin>.GetList(RequestPage<XJFAdmin> data)
        {
            var result = messageEntities.XJFAdmin.
                Where(e => e.XJFStatu == true).
                OrderBy(e => e.XJFStort).
                Skip((data.PageNum - 1) * data.PageSize).
                Take(data.PageSize).
                ToList();
            return result;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public XJFAdmin Login(string Key)
        {
            var result = messageEntities.XJFAdmin.FirstOrDefault(e => e.XJFAdminLgoinName == Key || e.XJFAdminPhone == Key || e.XJFAdminEmall == Key);
            //messageEntities.Database.SqlQuery(XJFAdmin, "",)
            //messageEntities.Database.ExecuteSqlCommandAsync("", new SqlParameter { });
            //messageEntities.XJFAdmin.Where(e => e.XJFAdminAliPayID == "1").ToList();
            return result;
            //return null;
        }

        /// <summary>
        /// 判断信息是否存在
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public XJFAdmin ExitAdmin(XJFAdmin data)
        {
            var result = messageEntities.XJFAdmin.FirstOrDefault(
                e =>
                e.XJFAdminLgoinName == data.XJFAdminLgoinName ||
                e.XJFAdminPhone == data.XJFAdminPhone ||
                e.XJFAdminEmall == data.XJFAdminEmall);
            return result;
        }
        
	 }
}