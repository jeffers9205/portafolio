using AccesoDatos.baseDeDatos;
using AccesoDatos.fabrica;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Vehiculo_ServicioDALC
    {

        public List<Carro_Servicio> ListarS(int id)
        {

            List<Vehiculo_Servicio> list = null;
            List<Carro_Servicio> list2 = new List<Carro_Servicio>();
            using (var db = new AUTOSEntities())
            {
                list = db.Vehiculo_Servicio.Where(d => d.ID_Servicio == id).ToList();
            }

            foreach (var item in list)
            {
                using (var db = new AUTOSEntities())
                {
                    item.Servicios = db.Servicios.Where(d => d.ID_Servicio== item.ID_Servicio).FirstOrDefault();
                }
            }
            foreach (var item in list)
            {
                using (var db = new AUTOSEntities())
                {
                    item.Vehiculo = db.Vehiculo.Where(d => d.ID_Vehiculo == item.ID_Vehiculo).FirstOrDefault();
                }
            }


            foreach (var item in list)
            {
                list2.Add(Vehiculo_ServicioFabrica.GetObj(item));
            }
            return list2;

        }



        public void Agregar(Carro_Servicio vehis)
        {

            using (var db = new AUTOSEntities())
            {
                db.Vehiculo_Servicio.Add(Vehiculo_ServicioFabrica.GetObj(vehis));

                db.SaveChanges();

            }
        }



        public Carro_Servicio GetVehiculo_Servicios(int id)
        {

            using (var db = new AUTOSEntities())
            {
                return Vehiculo_ServicioFabrica.GetObj(db.Vehiculo_Servicio.Find(id));

            }
        }



        public void Borrar(int id)
        {

            using (var db = new AUTOSEntities())
            {

                var Vehi = db.Vehiculo_Servicio.Find(id);
                db.Vehiculo_Servicio.Remove(Vehi);
                db.SaveChanges();


            }
        }


    }
}
