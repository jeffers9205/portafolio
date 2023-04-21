using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.baseDeDatos;
using Entidad;

namespace AccesoDatos.fabrica
{
    public static class VehiculoFabrica
    {
        public static Carro GetVehiculo(Vehiculo vehiculo)
        {
            return new Carro
            {

                ID_Vehiculo = vehiculo.ID_Vehiculo,
                Placa = vehiculo.Placa,
                Dueño = vehiculo.Dueño,
                Marca = vehiculo.Marca

            };
        }

        public static Vehiculo GetVehiculo(Carro carro)
        {
            return new Vehiculo
            {
                ID_Vehiculo = carro.ID_Vehiculo,
                Placa = carro.Placa,
                Dueño = carro.Dueño,
                Marca = carro.Marca
            };
        }
    }
}