// Autor: Isidro Aguilar
// Fecha: 01/12/2014
// Descripción: Control de Cuenta de Cliente.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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

        public async Task<ActionResult> Ingresar(Usuario usuario)
        {
            try
            {
                string expresion = string.Format("Usuario = \"{0}\" And Contrasena = \"{1}\"", usuario.Usuario, usuario.Contrasena);
                Parametro[] parametros = new Parametro[] { new Parametro("expresion", expresion) };
                var resultado = await ServiceController.ConsumirServicio<List<Usuario>>("UsuarioEpcon", "ObtenerUsuarioEpcon", "GET", parametros);
                usuarioEpcon = resultado.Where(u => u.Usuario == usuario.Usuario).Count() > 0 ? resultado.First() : null;
                if (usuarioEpcon != null)
                {
                    // Los datos de acceso son correctos, ingresa una entrada en el log.
                    Login logUsuario = new Login();
                    logUsuario.IdUsuarioEpcon = usuario.IdUsuarioEpcon;
                    logUsuario.Ip = "192.168.1.1";
                    logUsuario.FechaHora = DateTime.Now;
                    ServiceController.ConsumirServicio<bool, LogEpcon>("Cuenta", "CrearLogin", "POST", login);
                    // Autentica al usuario y lo almacena en sesión.
                    FormsAuthentication.SetAuthCookie(usuarioEpcon.Usuario, false);
                    Session["Usuario"] = usuarioEpcon;
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