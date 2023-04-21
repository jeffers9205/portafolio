using LogicaNegocio;
using System;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace Proyecto.Controllers
{
    public class Vehiculo_ServicioController : Controller
    {
        // GET: Vehiculo_Servicio
        public ActionResult Index()
        {
            var Veh = ServiciosNC.ListarServicios();
            return View(Veh);
        }


        public ActionResult listaS(int id)

        {
            var vehi = Vehiculo_ServicioNC.ListarS(id);
            return View(vehi);
        }



        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Vehiculo_Servicio vehis)
        {
            try
            {

                //if (vehis. == null || vehi.Placa == null || vehi.Marca == null)
                //{

                //    ModelState.AddModelError("", "Ocurrio un error al agregar vehiculos");
                //    return View(vehi);

                //}


                Vehiculo_ServicioNC.Agregar(vehis);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al asignar un vehículo");
                return View(vehis);
            }



        }








        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


            var Vehi = Vehiculo_ServicioNC.GetVehiculo_Servicio(id.Value);
            return View(Vehi);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {



                Vehiculo_ServicioNC.Eliminar(id);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al borrar un vehículo");
                TempData["Message"] = "Error dato relacionado!";

                return RedirectToAction("Eliminar");

                TempData["Message"] = "";
            }



        }







    }
}