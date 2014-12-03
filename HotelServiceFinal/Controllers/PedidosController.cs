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
    public class PedidosController : ApiController
    {
        HotelEntities db = new HotelEntities();

        [HttpGet]
        public IEnumerable<Pedidos> ObtenerPedidos()
        {
            try
            {
                return db.Pedidos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public Pedidos ObtenerPlatilloId(int idPedido)
        {
            try
            {
                return db.Pedidos.Find(idPedido);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public int CrearPedido(Pedidos pedidos)
        {
            try
            {
                db.Pedidos.Add(pedidos);
                db.SaveChanges();
                return pedidos.IdPedido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public bool EditarPedido(Pedidos pedido)
        {
            try
            {
                db.Entry(pedido).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public bool EliminarPedido(int idPedido)
        {
            try
            {
                Pedidos pedido = db.Pedidos.Find(idPedido);
                pedido.Estatus = 3;
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