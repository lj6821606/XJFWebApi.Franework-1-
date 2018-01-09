using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Request.Models
{
    /// <summary>
    /// 数据返回对象
    /// </summary>
    public class ReqsponsModels<T>
    {
        public ReqsponsModels()
        {

        }
        /// <summary>
        /// 错误信息
        /// </summary>
        /// <param name="coder">错误编号</param>
        /// <param name="message">错误信息</param>
        public ReqsponsModels(string coder, string message = "")
        {
            _code = coder;
            if (string.IsNullOrEmpty(message) || message.Equals(""))
                _codeInfo = ServiceErrorCodes.GetErrorMessage(coder);
            else
                _codeInfo = message;
        }
        private string _code;
        private string _codeInfo;
        private T _data;

        /// <summary>
        /// 返回码
        /// </summary>
        public string Code { get => _code; set => _code = value; }
        /// <summary>
        /// 返回码说明
        /// </summary>
        public string CodeInfo { get => _codeInfo; set => _codeInfo = value; }
        /// <summary>
        /// 返回对象
        /// </summary>
        public T Data { get => _data; set => _data = value; }
    }

    /// <summary>
    /// 返回码说明
    /// </summary>
    public static class ServiceErrorCodes
    {
        #region 错误编码
        #region 服务错误
        /// <summary>
        /// 未知错误
        /// </summary>
        public const string UnknownErrorCode = "0";
        /// <summary>
        /// Api服务错误
        /// </summary>
        public const string ApiServiceErrorCode = "1";
        /// <summary>
        /// Sql服务错误
        /// </summary>
        public const string SqlServiceErrorCode = "2";
        /// <summary>
        /// 您传入的参数有误
        /// </summary>
        public const string ParameterServiceCode = "3";
        /// <summary>
        /// 未找到数据
        /// </summary>
        public const string NullData = "4";
        /// <summary>
        /// 禁止删除
        /// </summary>
        public const string ProhibitDelete = "5";
        /// <summary>
        /// 成功
        /// </summary>
        public const string SuccessCode = "200";
        /// <summary>
        /// 失败
        /// </summary>
        public const string Failure = "500";
        /// <summary>
        /// 您传入的编号有误
        /// </summary>
        public const string NoErrorCode = "501";
        /// <summary>
        /// 显示页数错误
        /// </summary>
        public const string PageIndexErrorCode = "502";
        /// <summary>
        /// 显示条数错误
        /// </summary>
        public const string PageSizeErrorCode = "503";
        /// <summary>
        /// 数据请求错误
        /// </summary>
        public const string RequestDataError = "504";
        /// <summary>
        /// 数据验签失败
        /// </summary>
        public const string VerifySignErrorCode = "505";
        #endregion

        #region 用户管理
        /// <summary>
        /// 未找到用户
        /// </summary>
        public const string UnknownUser = "1001";
        /// <summary>
        /// 登录密码或账户错误
        /// </summary>
        public const string AccountOrPwdError = "1002";
        /// <summary>
        /// 已注册
        /// </summary>
        public const string AlreadyRegister = "1003";
        /// <summary>
        /// 用户编号不存在
        /// </summary>
        public const string CustomerNoExist = "1004";
        /// <summary>
        /// 用户编号不存在
        /// </summary>
        public const string CustomerExist = "1005";
        /// <summary>
        /// 手机号码格式错误
        /// </summary>
        public const string PhoneFormatError = "1006";
        /// <summary>
        /// 电子邮箱格式错误
        /// </summary>
        public const string EmailFormatError = "1007";
        /// <summary>
        /// 账户已锁定
        /// </summary>
        public const string UserLock = "1008";
        /// <summary>
        /// 该账户已被限制禁止登录
        /// </summary>
        public const string UserProhibitLogin = "1009";
        #endregion

        #region 地址管理
        #region  省市
        /// <summary>
        /// 省名称已存在
        /// </summary>
        public const string AddressProvinceNameExistsCode = "3100";
        #endregion
        #region 城市
        /// <summary>
        /// 城市名称已存在
        /// </summary>
        public const string AddressCityNameExistsCode = "3200";
        #endregion
        #region 区县
        /// <summary>
        /// 区县名称已存在
        /// </summary>
        public const string AddressDistrictNameExistsCode = "3300";
        #endregion
        #region 街道/乡镇
        /// <summary>
        /// 街道（乡镇）名称已存在
        /// </summary>
        public const string AddressStreetNameExistsCode = "3400";
        #endregion
        /// <summary>
        ///地址信息获取失败
        /// </summary>
        public const string GetAddressCodeError = "3501";
        #endregion

        #endregion

        public readonly static StringDictionary ErrorCodeTable = new StringDictionary()
        {
             #region 服务错误
             //服务错误
            { UnknownErrorCode, "未知错误。" },
            { ApiServiceErrorCode, "Api服务错误。" },
            { SqlServiceErrorCode, "Sql服务错误。" },
            { ParameterServiceCode, "您传入的参数有误。" },
            { SuccessCode, "success" },
            { Failure, "failed" },
            { NullData, "未找到数据。" },
            { NoErrorCode, "您传入的编号有误。" },
            { PageIndexErrorCode, "显示页数错误。" },
            { PageSizeErrorCode, "显示条数错误。" },
            { RequestDataError, "数据请求错误。" },
            { ProhibitDelete, "禁止删除。" },
            { VerifySignErrorCode, "数据签名验证失败" },

            #endregion

             #region 用户管理
            { UnknownUser, "未找到用户。" },
            { UserLock,"账户已锁定"},
            { UserProhibitLogin,"该账户已被限制禁止登录"},
            { AccountOrPwdError, "登录密码或账户错误。" },
            { AlreadyRegister, "账户已注册。" },
            { CustomerNoExist, "用户编号不存在" },
            { CustomerExist, "用户编号已存在" },
            { PhoneFormatError, "手机号码格式错误" },
            { EmailFormatError, "电子邮箱格式错误" },
            #endregion

             #region 地址管理
              #region  省市
              { AddressProvinceNameExistsCode, "省名称已存在。" },
              #endregion

              #region  城市
              { AddressCityNameExistsCode, "城市称已存在。" },
              #endregion

              #region 区县
              { AddressDistrictNameExistsCode, "区县称已存在。" },
              #endregion

              #region 街道/乡镇
             { AddressStreetNameExistsCode, "街道（乡镇）名称已存在。" },
             #endregion

             { GetAddressCodeError, "地址信息获取失败" },
             #endregion
        };

        /// <summary>
        /// 本地化在客户端自己处理
        /// </summary>
        public static string GetErrorMessage(string code)
        {
            if (ErrorCodeTable.ContainsKey(code))
                return ErrorCodeTable[code];

            return ErrorCodeTable[UnknownErrorCode];
        }
    }
}
