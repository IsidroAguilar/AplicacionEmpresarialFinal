using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelService;
using HotelService.Controllers;

namespace HotelService.Tests.Controllers
{
    [TestClass]
    public class ActDirectoryTest
    {
        [TestMethod]
        public void CreateNewRoom()
        {
            ActDirectoryController directoryMethods = new ActDirectoryController();

            var success = directoryMethods.AddRoom(56, "Admin123490", "56-09-54", "Enabled");

            Assert.IsTrue(success);
        }
    }
}
