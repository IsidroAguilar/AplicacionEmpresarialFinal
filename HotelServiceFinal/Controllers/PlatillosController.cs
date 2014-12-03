using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using LibreriaModelo.Modelo;

namespace HotelServiceFinal.Controllers
{
    public class PlatillosController : ApiController
    {
        HotelEntities db = new HotelEntities();

        [HttpGet]
        public IEnumerable<Platillos> ObtenerPlatillos()
        {
            try
            {
                return db.Platillos.Where(p => p.Estatus == 1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public Platillos ObtenerPlatilloId(int idPlatillo)
        {
            try
            {
                return db.Platillos.Find(idPlatillo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public int CrearPlatillo(Platillos platillo)
        {
            try
            {
                db.Platillos.Add(platillo);
                db.SaveChanges();
                return platillo.IdPlatillo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public bool EditarPlatillo(Platillos platillo)
        {
            try
            {
                db.Entry(platillo).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public bool EliminarPlatillo(int idPlatillo)
        {
            try
            {
                Platillos platillo = db.Platillos.Find(idPlatillo);
                platillo.Estatus = 3;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
	}
}