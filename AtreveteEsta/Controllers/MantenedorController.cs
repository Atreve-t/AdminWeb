using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtreveteEsta.Models;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using Newtonsoft.Json;

namespace AtreveteEsta.Controllers
{
    public class MantenedorController : Controller
    {



        IFirebaseClient Administrador;
        public MantenedorController()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "LWArAmsNs6X9EJT2H8xBWK9c2BZbmKx5pS",
                BasePath = "https://atreve-t-isi-default-rtdb.firebaseio.com/"
            };

            Administrador = new FirebaseClient(config);

        }



        // GET: Mantenedor
        public ActionResult IndexUsuarios()
        {
            Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
            FirebaseResponse response = Administrador.Get("usuarios");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                lista = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(response.Body);
                List<Usuario> listaContacto = new List<Usuario>();

                foreach (KeyValuePair<string, Usuario> elemento in lista)
                {
                    listaContacto.Add(new Usuario()
                    {
                        email = elemento.Value.email,
                        Password = elemento.Value.Password,
                        Tipo = elemento.Value.Tipo,
                        calificacion= elemento.Value.calificacion
                        
                    });
                }

                return View(listaContacto);
            }
            else
            {
                return View("Error");
            }

        }
        public ActionResult Top()
        {
            Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
            FirebaseResponse response = Administrador.Get("usuarios");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                lista = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(response.Body);
                List<Usuario> listaUsuario = new List<Usuario>();

                foreach (KeyValuePair<string, Usuario> elemento in lista)
                {
                    listaUsuario.Add(new Usuario()
                    {
                        email = elemento.Value.email,
                        Password = elemento.Value.Password,
                        Tipo = elemento.Value.Tipo,
                        calificacion=elemento.Value.calificacion
                    });
                }

                return View(listaUsuario);
            }
            else
            {
                return View("Error");
            }
        }
        //peores calificados
        public ActionResult PeoresCalificados()
        {
            Dictionary<string, Usuario> lista = new Dictionary<string, Usuario>();
            FirebaseResponse response = Administrador.Get("usuarios");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                lista = JsonConvert.DeserializeObject<Dictionary<string, Usuario>>(response.Body);
                List<Usuario> listaUsuario = new List<Usuario>();

                foreach (KeyValuePair<string, Usuario> elemento in lista)
                {
                    listaUsuario.Add(new Usuario()
                    {
                        email = elemento.Value.email,
                        calificacion = elemento.Value.calificacion
                    });
                }

                return View(listaUsuario);
            }
            else
            {
                return View("Error");
            }
        }
        //
        public ActionResult GarajesUso()
        {
            Dictionary<string, Garaje> lista = new Dictionary<string, Garaje>();
            FirebaseResponse response = Administrador.Get("garages");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                lista = JsonConvert.DeserializeObject<Dictionary<string, Garaje>>(response.Body);
                List<Garaje> listaGarajeenUso = new List<Garaje>();

                foreach (KeyValuePair<string, Garaje> elemento in lista)
                {
                    listaGarajeenUso.Add(new Garaje()
                    {
                        Alto = elemento.Value.Alto,
                        Ancho = elemento.Value.Ancho,
                        Direccion = elemento.Value.Direccion,
                        Estado= elemento.Value.Estado,
                        Largo= elemento.Value.Largo,
                        Latitud = elemento.Value.Latitud,
                        Longitud = elemento.Value.Longitud,
                        Precio= elemento.Value.Precio,
                        PropietarioId = elemento.Value.PropietarioId

                    });
                }

                return View(listaGarajeenUso);
            }
            else
            {
                return View("Error");
            }
        }
    }
}