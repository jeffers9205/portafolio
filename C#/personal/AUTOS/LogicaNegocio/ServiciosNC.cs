using Entidad;
using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ServiciosNC
    {
        private static ServiciosDALC obj = new ServiciosDALC();
        public static List<Servicio> ListarServicios()
        {

            return obj.ListarServicios();

        }



        public static void Agregar(Servicio Serv)
        {
            obj.Agregar(Serv);


        }



        public static Servicio GetServicios(int id)
        {


            return obj.GetServicios(id);

        }

        public static void Editar(Servicio Serv)
        {


            obj.Editar(Serv);

        }

        public static void Eliminar(int id)
        {


            obj.Borrar(id);

        }



    }
}
