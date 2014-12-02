// Autor: Isidro Aguilar
// Fecha: 01/12/2014
// Descripción: Control de Cuenta de Cliente.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using System.Threading.Tasks;
using LibreriaModelo.Auxiliar;
using LibreriaModelo.Modelo;

namespace Cliente.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Ingresar(Usuarios usuario)
        {
            try
            {
                string expresion = string.Format("Usuario = \"{0}\" And Contrasena = \"{1}\"", usuario.Nombre, usuario.Contrasena);
                Parametro[] parametros = new Parametro[] { new Parametro("expresion", expresion) };
                var resultado = await ServiceController.ConsumirServicio<List<Usuarios>>("Usuario", "ObtenerUsuario", "GET", parametros);
                usuario = resultado.Where(u => u.Nombre == usuario.Apellidos).Count() > 0 ? resultado.First() : null;
                if (usuario != null)
                {
                    // Los datos de acceso son correctos, ingresa una entrada en el log.
                    Login logUsuario = new Login();
                    logUsuario.IdUsuario = usuario.IdUsuario;
                    logUsuario.FechaHora = DateTime.Now;
                    ServiceController.ConsumirServicio<bool, Login>("LoginUsuario", "CrearLogUsuario", "POST", logUsuario);
                    // Autentica al usuario y lo almacena en sesión.
                    FormsAuthentication.SetAuthCookie(usuario.Nombre, false);
                    Session["Usuario"] = usuario;
                    return Json(new { result = true, url = Url.Action("Index", "Home") });
                }
                else
                {
                    return Json(new { result = false });
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ActionResult CerrarSesion()
        {
            // Proceso de logout.
            FormsAuthentication.SignOut();
            Session.Clear();
            return RedirectToAction("Index");
        }
    }
}