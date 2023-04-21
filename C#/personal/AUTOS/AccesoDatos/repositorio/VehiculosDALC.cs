using Entidad;
using AccesoDatos.baseDeDatos;
using AccesoDatos.fabrica;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class VehiculosDALC
    {

        public void Agregar(Carro Veh)
        {

            using (var db = new AUTOSEntities())
            {
                db.Vehiculo.Add(VehiculoFabrica.GetVehiculo(Veh));

                db.SaveChanges();

            }
        }

    
        public List<Carro> ListarVehiculo() {
        
            List<Vehiculo> list = null;
            List<Carro> list2 = new List<Carro>();
            using (var db = new AUTOSEntities())
            {
                list = db.Vehiculo.ToList();
            }

            foreach (var item in list)
            {
                list2.Add(VehiculoFabrica.GetVehiculo(item));
            }
            return list2;

        }


        public Carro GetVehiculo(int id)
        {

            using (var db = new AUTOSEntities())
            {
                return VehiculoFabrica.GetVehiculo(db.Vehiculo.Find(id));

            }
        }


        public void  Editar(Carro Vehi)
        {

            using (var db = new AUTOSEntities())
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

            using (var db = new AUTOSEntities())
            {

                var Vehi = db.Vehiculo.Find(id);
                db.Vehiculo.Remove(Vehi);
                db.SaveChanges();
 

            }
        }



    }
}
