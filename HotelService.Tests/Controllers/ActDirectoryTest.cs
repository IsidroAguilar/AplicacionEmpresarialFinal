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
        ActDirectoryController directoryMethods = new ActDirectoryController();

        [TestMethod]
        public void CreateNewRoom()
        {
            var success = directoryMethods.AddRoom(56, "Admin123490", "56-09-54", "Enabled");

            Assert.IsTrue(success);
        }


        [TestMethod]
        public void ValidateCredentials()
        {
            var success = directoryMethods.ValidateCredentials("", "Admin123490");

            Assert.IsTrue(success);
        }


        [TestMethod]
        public void ChangeRoomStatus()
        {
            var success = directoryMethods.ChangeRoomStatus(56, "AdminPass", "newStatus");

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void SignInTenant()
        {
            var success = directoryMethods.SignInTenant(60, "Admin123490", "Eduardo", "Muñoz", "Lalo123", "lalo@hotmail.com", "Lalo123");

            Assert.IsTrue(success);
        }

        public void LogOutTenant()
        {
            var success = directoryMethods.LogOutTenant(60, "Admin123490");

            Assert.IsTrue(success);
        }

        
        public void BlockRoom()
        {
            var success = directoryMethods.BlockRoom(60, "Admin123490");

            Assert.IsTrue(success);
        }
    }
}
