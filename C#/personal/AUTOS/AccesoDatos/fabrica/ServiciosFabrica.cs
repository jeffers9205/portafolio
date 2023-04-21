using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.baseDeDatos;
using Entidad;

namespace AccesoDatos.fabrica
{
    public static class ServiciosFabrica
    {
        public static Servicio GetServicio(Servicios carro)
        {
            return new Servicio
            {

                ID_Servicio = carro.ID_Servicio,
                Descripcion = carro.Descripcion,
                Monto = carro.Monto

            };
        }

        public static Servicios GetServicio(Servicio carro)
        {
            return new Servicios
            {
                ID_Servicio = carro.ID_Servicio,
                Descripcion = carro.Descripcion,
                Monto = carro.Monto
            };
        }
    }
}