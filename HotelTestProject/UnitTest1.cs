using System;
using HotelServiceFinal.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarCredenciales()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.ValidateCredentials("60", "Admin1234");
            Assert.IsTrue(exito);
        }
    }
}
