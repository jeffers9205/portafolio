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

        public List<Vehiculo_Servicio> ListarS(int id)
        {

            using (var db = new masterEntities())
            {
                return db.Vehiculo_Servicio.Where(d => d.ID_Servicio == id).ToList();

            }
        }


        public void Agregar(Vehiculo_Servicio vehis)
        {

            using (var db = new masterEntities())
            {
                db.Vehiculo_Servicio.Add(vehis);

                db.SaveChanges();

            }
        }



        public Vehiculo_Servicio GetVehiculo_Servicios(int id)
        {

            using (var db = new masterEntities())
            {
                return db.Vehiculo_Servicio.Find(id);

            }
        }



        public void Borrar(int id)
        {

            using (var db = new masterEntities())
            {

                var Vehi = db.Vehiculo_Servicio.Find(id);
                db.Vehiculo_Servicio.Remove(Vehi);
                db.SaveChanges();


            }
        }


    }
}
