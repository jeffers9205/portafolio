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
        public static List<Servicios> ListarServicios()
        {

            return obj.ListarServicios();

        }



        public static void Agregar(Servicios Serv)
        {
            obj.Agregar(Serv);


        }



        public static Servicios GetServicios(int id)
        {


            return obj.GetServicios(id);

        }

        public static void Editar(Servicios Serv)
        {


            obj.Editar(Serv);

        }

        public static void Eliminar(int id)
        {


            obj.Borrar(id);

        }



    }
}
