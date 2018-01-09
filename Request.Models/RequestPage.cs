using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request.Models
{
    /// <summary>
    /// 分页对象
    /// </summary>
    public class RequestPage<T>
    {
        /// <summary>
        /// 每页大小
        /// </summary>
        private int _pageSize = 20;

        /// <summary>
        /// 请求页数
        /// </summary>
        private int _pageNum = 0;

        /// <summary>
        /// 请求参数
        /// </summary>
        private T _data;

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get => _pageSize; set => _pageSize = value; }
        /// <summary>
        /// 请求页数
        /// </summary>
        public int PageNum { get => _pageNum; set => _pageNum = value; }
        /// <summary>
        /// 请求参数
        /// </summary>
        public T Data { get => _data; set => _data = value; }
    }
}
