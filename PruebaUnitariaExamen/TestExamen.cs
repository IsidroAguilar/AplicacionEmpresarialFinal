using System;
using HotelServiceFinal.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaUnitariaExamen
{
    [TestClass]
    public class TestExamen
    {
        [TestMethod]
        public void AgregarCuarto()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.AddRoom(1,"adminPass","1234567","disponible");
            Assert.IsTrue(exito);
        }

        [TestMethod]
        public void BloquearCuarto()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.BlockRoom(1, "Adm123");
            Assert.IsTrue(exito);
        }

        [TestMethod]
        public void CambiarEstatusCuarto()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.ChangeRoomStatus(1, "Adm123","ocupado");
            Assert.IsTrue(exito);
        }

        [TestMethod]
        public void CheckOut()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.LogOutTenant(1,"Adm123");
            Assert.IsTrue(exito);
        }

        [TestMethod]
        public void CheckIn()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.SignInTenant(1, "adminPass", "1234567", "disponible","dsadas","dasdasda","asdasdas");
            Assert.IsTrue(exito);
        }


        [TestMethod]
        public void ValidarCredenciales()
        {
            ActDirectoryController adc = new ActDirectoryController();
            var exito = adc.ValidateCredentials("nombre","Admin123");
            Assert.IsTrue(exito);
        }

        [TestMethod]
        public void ObtenerPlatillos()
        {
           
           PlatillosController pc = new PlatillosController();
            var exito = pc.ObtenerPlatillos();
            Assert.IsNotNull(exito);
        }


    }
}
