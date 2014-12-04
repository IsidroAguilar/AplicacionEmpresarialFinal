using System.Configuration;
using System.Web.Configuration;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using LibreriaModelo.Modelo;
using HotelServiceFinal.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace RoomServiceCaribeResort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);
            //ConfigurationSection section = config.GetSection("connectionStrings");
            //if (!section.SectionInformation.IsProtected)
            //{
            //    section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
            //    config.Save();
            //}
            return View();
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "ISSC 511 - Universidad de la Salle Bajío";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "ISSC 511 - Universidad de la Salle Bajío";
            return View();
        }
        public async Task<ActionResult> ObtenerPlatillos([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                var platillos = await ServiceController.ConsumirServicio<List<Platillos>>("Platillos", "ObtenerPlatillos", "GET");
                DataSourceResult result = platillos.ToDataSourceResult(request, p => new
                {
                    IdPlatillo = p.IdPlatillo,
                    NombrePlatillo = p.NombrePlatillo,
                    Descripcion = p.Descripcion
                });
                return Json(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}