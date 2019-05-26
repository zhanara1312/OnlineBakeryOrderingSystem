using BakeryUI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineBakeryOrderingSystem;
using System;
using System.Collections.Generic;

namespace BakeryTest
{
    [TestClass]
    public class BakeriesControllerTest
    {
        [TestMethod]
        public void TestIndexViewWithNoLogin()
        {
            //AAA Arrange, Act and Assert
            //Arrange
            var controller = new BakeriesController();

            //Act and assert
            Assert.ThrowsException
                <NullReferenceException>
                (() => controller.Index());
        }

        [TestMethod]
        public void TestIndexViewWithEmptyLogin()
        {
            //Arrange
            var controller = new BakeriesController();
            controller.UserName = string.Empty;

            //Act and Assert
            Assert.ThrowsException
                <NullReferenceException>
                (() => controller.Index());
        }

        [TestMethod]
        public void TestIndexViewWithLogin()
        {
            //Arrange
            var controller = new BakeriesController();
            controller.UserName = "jen@gmail.com";

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            var bakeries =
                (IEnumerable<Bakery>)result.ViewData.Model;
            var count = 0;
            foreach (var bakery in bakeries)
            {
                count++;
            }
            Assert.AreEqual<int>(3, count);
        }
    }
}


