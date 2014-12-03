
using Cliente.Models;
using LibreriaModelo.Auxiliar;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace Cliente.Controllers
{
    [Autorizar]
    public class ServiceController : Controller
    {

        private static string baseUri = WebConfigurationManager.AppSettings["baseUri"];

        public static async Task<T> ConsumirServicio<T>(string controller, string action, string method)
        {
            // Variables del método
            HttpResponseMessage response = new HttpResponseMessage();
            var datos = default(T);
            try
            {
                // Validar método HTTP.
                method = method.ToUpper();
                // Realizar llamada al servicio.
                using (var client = new HttpClient())
                {
                    // Configuración del cliente HTTP.
                    client.BaseAddress = new Uri(baseUri);
                    switch (method)
                    {
                        case "GET":
                            response = await client.GetAsync((controller + "/" + action));
                            break;
                        //case "POST":
                        //    response = await client.PostAsJsonAsync((controller + "/" + action), "");
                        //    break;
                    }
                    // Obtener respuesta.
                    if (response.IsSuccessStatusCode)
                    {
                        //datos = await response.Content.ReadAsAsync<T>();
                    }
                    else
                    {
                        var error = client.GetAsync((controller + "/" + action)).Result.Content.ReadAsStringAsync();
                        throw error.Exception;
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<T> ConsumirServicio<T>(string controller, string action, string method, IEnumerable<Parametro> parametros)
        {
            // Variables del método
            HttpResponseMessage response = new HttpResponseMessage();
            var datos = default(T);
            try
            {
                // Validar método HTTP.
                method = method.ToUpper();
                // Realizar llamada al servicio.
                using (var client = new HttpClient())
                {
                    // Configuración del cliente HTTP.
                    client.BaseAddress = new Uri(baseUri);
                    switch (method)
                    {
                        case "GET":
                            string uri = controller + "/" + action;
                            foreach (Parametro p in parametros)
                            {
                                if (p == parametros.First()) uri += "?";
                                uri += p.Nombre + "=" + p.Valor;
                                if (p != parametros.Last()) uri += "&";
                            }
                            response = await client.GetAsync(uri);
                            break;
                        //case "POST":
                        //    response = await client.PostAsJsonAsync((controller + "/" + action), "");
                        //    break;
                    }
                    // Obtener respuesta.
                    if (response.IsSuccessStatusCode)
                    {
                        //datos = await response.Content.ReadAsAsync<T>();
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task<T> ConsumirServicio<T, D>(string controller, string action, string method, D parametro)
        {
            // Variables del método
            HttpResponseMessage response = new HttpResponseMessage();
            var datos = default(T);
            try
            {
                // Validar método HTTP.
                method = method.ToUpper();
                // Realizar llamada al servicio.
                using (var client = new HttpClient())
                {
                    // Configuración del cliente HTTP.
                    client.BaseAddress = new Uri(baseUri);
                    switch (method)
                    {
                        case "GET":
                            if (parametro != null)
                                response = await client.GetAsync((controller + "/" + action + "?" + parametro));
                            else
                                response = await client.GetAsync((controller + "/" + action));
                            break;
                        //case "POST":
                        //    response = await client.PostAsJsonAsync((controller + "/" + action), parametro);
                        //    break;
                    }
                    // Obtener respuesta.
                    if (response.IsSuccessStatusCode)
                    {
                        //datos = await response.Content.ReadAsAsync<T>();
                    }
                    else
                    {
                        //var error = client.PostAsJsonAsync((controller + "/" + action), parametro).Result.Content.ReadAsStringAsync();
                        //throw error.Exception;
                    }
                }
                return datos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}