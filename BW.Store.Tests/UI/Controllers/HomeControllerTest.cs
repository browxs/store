using BW.Store.UI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BW.Store.Tests.UI.Controllers
{
    [TestClass, TestCategory("Controllers/HomeController")]
    public class HomeControllerTest
    {
        // dado HomeController
        [TestMethod]
        public void OMetodoIndexDeveraRetornarUmaView()
        {
            // arrange
            var homeController = new HomeController();

            // action
            var result = homeController.Index();

            // assert
            Assert.AreEqual(typeof(ViewResult), result.GetType());
        }
    }
}
