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
    public class RestaurantesController : ApiController
    {
        HotelEntities db = new HotelEntities();

        [HttpGet]
        public IEnumerable<Restaurantes> ObtenerRestaurantes()
        {
            try
            {
                return db.Restaurantes.Where(p => p.Estatus == 1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public Restaurantes ObtenerRestauranteId(int idRestaurante)
        {
            try
            {
                return db.Restaurantes.Find(idRestaurante);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public int CrearRestaurante(Restaurantes restaurante)
        {
            try
            {
                db.Restaurantes.Add(restaurante);
                db.SaveChanges();
                return restaurante.IdRestaurante;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public bool EditarRestaurante(Restaurantes restaurante)
        {
            try
            {
                db.Entry(restaurante).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public bool EliminarRestaurante(int idRestaurante)
        {
            try
            {
                Restaurantes restaurante = db.Restaurantes.Find(idRestaurante);
                restaurante.Estatus = 3;
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