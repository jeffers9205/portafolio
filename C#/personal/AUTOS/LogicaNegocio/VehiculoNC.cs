using AccesoDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class VehiculoNC
    {
        private static VehiculosDALC obj = new VehiculosDALC();

        public  static void  Agregar(Carro Veh) {
            obj.Agregar(Veh);
          

        }




        public static List<Carro> ListarVehiculo()
        {
           

                return obj.ListarVehiculo();

        }

        public static Carro GetVehiculo(int id)
        {


            return obj.GetVehiculo(id);

        }
   public static void Editar(Carro Vehi)
        {


             obj.Editar(Vehi);

        }
     
        public static void Eliminar(int id)
        {


            obj.Borrar(id);

        }



    }
}
