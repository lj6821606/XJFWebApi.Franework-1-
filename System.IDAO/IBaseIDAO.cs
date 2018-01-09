using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IDAO
{
    /// <summary>
    /// 公用接口信息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseIDAO<T>
    {
        /// <summary>
        /// 添加一条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        Task<int> AddFirst(T data);

        /// <summary>
        /// 添加多条信息
        /// </summary>
        /// <param name="data">添加对象</param>
        /// <returns>受影响行数</returns>
        //Task<int> AddList(List<T> data);

        /// <summary>
        /// 删除一条信息
        /// </summary>
        /// <param name="Id">修改对象ID</param>
        /// <returns>受影响行数</returns>
        Task<int> DelectFirst(string Id);

        /// <summary>
        /// 修改一条信息
        /// </summary>
        /// <param name="data">修改对象</param>
        /// <returns>受影响行数</returns>
        Task<int> UpdateFirst(T data);

        /// <summary>
        /// 根据ID查询一条信息
        /// </summary>
        /// <param name="Id">ID</param>
        /// <returns></returns>
        T GetFirst(string Id);

        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="data">条件</param>
        /// <returns></returns>
        List<T> GetList(Request.Models.RequestPage<T> data);

    }
}
