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
    public class HabitacionController : ApiController
    {
        HotelEntities db = new HotelEntities();

        [HttpGet]
        public IEnumerable<Habitacion> ObtenerHabitaciones()
        {
            try
            {
                return db.Habitacion.Where(p => p.Estatus == 1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public Habitacion ObtenerHabitacionId(int idHabitacion)
        {
            try
            {
                return db.Habitacion.Find(idHabitacion);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public int CrearHabitacion(Habitacion habitacion)
        {
            try
            {
                db.Habitacion.Add(habitacion);
                db.SaveChanges();
                return habitacion.IdHabitacion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public bool EditarHabitacion(Habitacion habitacion)
        {
            try
            {
                db.Entry(habitacion).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public bool EliminarHabitacion(int idHabitacion)
        {
            try
            {
                Habitacion habitacion = db.Habitacion.Find(idHabitacion);
                habitacion.Estatus = 3;
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