using Entidad;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.Controllers
{
    public class VehiculoController : Controller
    {
        // GET: Vehiculo
        public ActionResult Index()
        {
            var Veh = VehiculoNC.ListarVehiculo();
            return View(Veh);
        }







        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Vehiculo vehi)
        {
            try
            {

                if (vehi.Dueño == null || vehi.Placa == null || vehi.Marca == null) {

                    ModelState.AddModelError("", "Error al agregar vehículo");
                    return View(vehi);

                }


                VehiculoNC.Agregar(vehi);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Error al agregar vehículo");
                return View(vehi);
            }



        }


        public ActionResult GetDetalle(int id)

        {
            var vehi = VehiculoNC.GetVehiculo(id);
            return View(vehi);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {

            var Vehi = VehiculoNC.GetVehiculo(id);
            return View(Vehi);
        }

        [HttpPost]
        public ActionResult Editar(Vehiculo vehi)
        {
            try
            {

                if (vehi.Dueño == null || vehi.Placa == null || vehi.Marca == null)
                {

                    ModelState.AddModelError("", "Error al modificar vehículo");
                    return View(vehi);

                }


                VehiculoNC.Editar(vehi);
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", " Error al editar vehículo");
                return View(vehi);
            }



        }


        [HttpGet]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var Vehi = VehiculoNC.GetVehiculo(id.Value);
            return View(Vehi);
        }

        [HttpPost]
        public ActionResult Eliminar(int id)
        {
            try
            {

     

                VehiculoNC.Eliminar(id);
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