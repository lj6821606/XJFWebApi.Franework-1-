using Request.Models;
using System;
using System.Collections.Generic;
using System.IDAO;
using System.Linq;
using System.Models;
using System.Text;
using System.Threading.Tasks;

namespace System.DAO
{
	 public class XJFAuthorityDAO : Base_System, IBaseIDAO<XJFAuthority>
	 {
	 	/// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFAuthority>.AddFirst(XJFAuthority data)
        {
            messageEntities.XJFAuthority.Add(data);
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFAuthority>.DelectFirst(string Id)
        {
            throw new NotImplementedException();
            //var data = messageEntities.XJFAuthority.First(e => e.XJFAuthorityID == Id);
            //data.XJFStatu = false;
            //var result = messageEntities.SaveChangesAsync();
            //return result;
            //throw ;
        }
        /// <summary>
        /// 修改一条数据对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> IBaseIDAO<XJFAuthority>.UpdateFirst(XJFAuthority data)
        {
            messageEntities.Entry<XJFAuthority>(data).State = Data.Entity.EntityState.Modified;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 根据ID查询一条信息
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        XJFAuthority IBaseIDAO<XJFAuthority>.GetFirst(string Id)
        {
            throw new NotImplementedException();
            //var result = messageEntities.XJFAuthority.FirstOrDefault(e => e.XJFAuthorityID == Id);
            //return result;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">分页对象</param>
        /// <returns>list 集合对象</returns>
        List<XJFAuthority> IBaseIDAO<XJFAuthority>.GetList(RequestPage<XJFAuthority> data)
        {
            throw new NotImplementedException();
            //var result = messageEntities.XJFAuthority.
            //    Where(e => e.XJFStatu == true).
            //    OrderBy(e => e.XJFStort).
            //    Skip((data.PageNum - 1) * data.PageSize).
            //    Take(data.PageSize).
            //    ToList();
            //return result;
        }
	 }
}