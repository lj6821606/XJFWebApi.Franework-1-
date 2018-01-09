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
    /*
	 public class XJFSchoolDAO : Base_System, IBaseIDAO<XJFSchool>
	 {
	 	/// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFSchool>.AddFirst(XJFSchool data)
        {
            messageEntities.XJFSchool.Add(data);
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        Task<int> IBaseIDAO<XJFSchool>.DelectFirst(string Id)
        {
            var data = messageEntities.XJFSchool.First(e => e.XJFSchoolID == Id);
            data.XJFStatu = false;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 修改一条数据对象
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<int> IBaseIDAO<XJFSchool>.UpdateFirst(XJFSchool data)
        {
            messageEntities.Entry<XJFSchool>(data).State = Data.Entity.EntityState.Modified;
            var result = messageEntities.SaveChangesAsync();
            return result;
        }
        /// <summary>
        /// 根据ID查询一条信息
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        XJFRole IBaseIDAO<XJFSchool>.GetFirst(string Id)
        {
            var result = messageEntities.XJFSchool.FirstOrDefault(e => e.XJFSchoolID == Id);
            return result;
        }

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">分页对象</param>
        /// <returns>list 集合对象</returns>
        List<XJFSchool> IBaseIDAO<XJFSchool>.GetList(RequestPage<XJFSchool> data)
        {
            var result = messageEntities.XJFSchool.
                Where(e => e.XJFStatu == true).
                OrderBy(e => e.XJFStort).
                Skip((data.PageNum - 1) * data.PageSize).
                Take(data.PageSize).
                ToList();
            return result;
        }
	 }*/
}