using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XJFWebApi.Franework;
using XJFWebApi.Franework.Controllers;

namespace XJFWebApi.Franework.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
       

        [TestMethod]
        public void GetById()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
           

            // 断言
           
        }

        [TestMethod]
        public void Post()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
            controller.Post("value");

            // 断言
        }

        [TestMethod]
        public void Put()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
            controller.Put(5, "value");

            // 断言
        }

        [TestMethod]
        public void Delete()
        {
            // 排列
            ValuesController controller = new ValuesController();

            // 操作
            controller.Delete(5);

            // 断言
        }
    }
}
