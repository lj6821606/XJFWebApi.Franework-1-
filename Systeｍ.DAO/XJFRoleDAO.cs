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
    public class XJFRoleDAO : Base_System, IBaseIDAO<XJFRole>
    {
        /// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFRole>.AddFirst(XJFRole data)
        {
            messageEntities.XJFRole.Add(data);
            var result = messageEntities.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// 添加多条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> AddList(List<XJFRole> data)
        {
            messageEntities.XJFRole.AddRange(data);
            var result = messageEntities.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFRole>.DelectFirst(string Id)
        {
            var data = messageEntities.XJFRole.First(e => e.XJFRoleID == Id);
            data.XJFStatu = false;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// 修改一条数据对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> IBaseIDAO<XJFRole>.UpdateFirst(XJFRole data)
        {
            messageEntities.Entry<XJFRole>(data).State = Data.Entity.EntityState.Modified;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// 根据ID查询一条信息
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        XJFRole IBaseIDAO<XJFRole>.GetFirst(string Id)
        {
            var result = messageEntities.XJFRole.FirstOrDefault(e => e.XJFRoleID == Id);
            return result;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">分页对象</param>
        /// <returns>list 集合对象</returns>
        List<XJFRole> IBaseIDAO<XJFRole>.GetList(RequestPage<XJFRole> data)
        {
            var result = messageEntities.XJFRole.
                Where(e => e.XJFStatu == true).
                OrderBy(e => e.XJFStort).
                Skip((data.PageNum - 1) * data.PageSize).
                Take(data.PageSize).
                ToList();
            return result;
        }
    }
}
