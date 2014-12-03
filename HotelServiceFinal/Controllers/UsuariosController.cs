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
    public class UsuariosController : ApiController
    {
        HotelEntities db = new HotelEntities();


        [HttpGet]
        public IEnumerable<Usuarios> ObtenerUsuarios()
        {
            try
            {
                return db.Usuarios.Where(c => c.Estatus == 1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public Usuarios ObtenerUsuarioId(int idUsuario)
        {
            try
            {
                return db.Usuarios.Find(idUsuario);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //[HttpGet]
        //public IEnumerable<Usuarios> ObtenerUsuario(string expresion)
        //{
        //    try
        //    {
        //        return db.Usuarios.Where(expresion).Where(u => u.Estatus == 1);
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}


        [HttpPost]
        public int CrearUsuario(Usuarios usuario)
        {
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return usuario.IdUsuario;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public bool EditarUsuario(Usuarios usuario)
        {
            try
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                Usuarios usuario = db.Usuarios.Find(idUsuario);
                usuario.Estatus = 3;
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