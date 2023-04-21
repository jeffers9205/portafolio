using Entidad;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VehiculosDALC
    {

        public void Agregar(Vehiculo Veh)
        {

            using (var db = new masterEntities())
            {
                db.Vehiculo.Add(Veh);

                db.SaveChanges();

            }
        }

    
        public List<Vehiculo> ListarVehiculo() {
            using (var db = new masterEntities())

                return db.Vehiculo.ToList();

        }


        public Vehiculo GetVehiculo(int id)
        {

            using (var db = new masterEntities())
            {
                return db.Vehiculo.Find(id);

            }
        }


        public void  Editar(Vehiculo Vehi)
        {

            using (var db = new masterEntities())
            {
                var d = db.Vehiculo.Find(Vehi.ID_Vehiculo);
                d.Dueño = Vehi.Dueño;
                d.Marca = Vehi.Marca;
                d.Placa = Vehi.Placa;
                db.SaveChanges();

            }
        }



        public void Borrar(int id)
        {

            using (var db = new masterEntities())
            {

                var Vehi = db.Vehiculo.Find(id);
                db.Vehiculo.Remove(Vehi);
                db.SaveChanges();
               

            }
        }



    }
}
