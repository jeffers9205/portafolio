using AccesoDatos;
using System;
using Entidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Vehiculo_ServicioNC
    {


        private static Vehiculo_ServicioDALC  obj = new Vehiculo_ServicioDALC();
        public static List<Vehiculo_Servicio> ListarS(int id)
        {

            return obj.ListarS(id);

        }


        public static void Agregar(Vehiculo_Servicio Vehis)
        {
            obj.Agregar(Vehis);


        }




        public static Vehiculo_Servicio GetVehiculo_Servicio(int id)
        {


            return obj.GetVehiculo_Servicios(id);

        }

        public static void Eliminar(int id)
        {


            obj.Borrar(id);

        }


    }
}
