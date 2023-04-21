using Entidad;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
      

        public ActionResult Index()
        {
            var Veh = ServiciosNC.ListarServicios() ;
            return View(Veh);
        }





        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Servicios Serv)
        {
            try
            {

                if (Serv.Monto == null || Serv.Descripción == null )
                {

                    ModelState.AddModelError("", "Error al agregar un servicio");
                    return View(Serv);

                }


                ServiciosNC.Agregar(Serv);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al agregar un servicio");
                return View(Serv);
            }

        }


        public ActionResult GetDetalle(int id)

        {
            var Serv = ServiciosNC.GetServicios(id);
            return View(Serv);
        }





        [HttpGet]
        public ActionResult Editar(int id)
        {

            var Serv = ServiciosNC.GetServicios(id);
            return View(Serv);
        }

        [HttpPost]
        public ActionResult Editar(Servicios Serv)
        {
            try
            {

                if (Serv.Descripción == null || Serv.Monto == null)
                {

                    ModelState.AddModelError("", "Error al modificar un servicio");
                    return View(Serv);

                }


                ServiciosNC.Editar(Serv);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al editar servicio");
                return View(Serv);
            }



        }









        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


            var Serv = ServiciosNC.GetServicios(id.Value);
            return View(Serv);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {



                ServiciosNC.Eliminar(id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "error al eliminar un servicio");
                TempData["Message"] = "Error dato relacionado!";

                return RedirectToAction("Eliminar");

                TempData["Message"] = "";
                return View();
            }



        }







    }
}