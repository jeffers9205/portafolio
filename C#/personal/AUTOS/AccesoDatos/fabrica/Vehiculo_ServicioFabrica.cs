using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.baseDeDatos;
using Entidad;
using AccesoDatos.fabrica;

namespace AccesoDatos.fabrica
{
    public static class Vehiculo_ServicioFabrica
    {

        public static Vehiculo_Servicio GetObj(Carro_Servicio carroServicio)
        {
            return new Vehiculo_Servicio
            {

                ID_Vehiculo_Servicio = carroServicio.ID_Vehiculo_Servicio,
                ID_Servicio = carroServicio.ID_Servicio,
                ID_Vehiculo = carroServicio.ID_Vehiculo,
                Servicios = new Servicios
                {
                    ID_Servicio = carroServicio.Servicios.ID_Servicio,
                    Descripcion = carroServicio.Servicios.Descripcion,
                    Monto = carroServicio.Servicios.Monto
                },
                Vehiculo = new Vehiculo
                {
                    ID_Vehiculo = carroServicio.Vehiculo.ID_Vehiculo,
                    Placa = carroServicio.Vehiculo.Placa,
                    Dueño = carroServicio.Vehiculo.Dueño,
                    Marca = carroServicio.Vehiculo.Marca
                }

            };
        }

        public static Carro_Servicio GetObj(Vehiculo_Servicio vehiculoServicio)
        {
            return new Carro_Servicio
            {
                ID_Vehiculo_Servicio = vehiculoServicio.ID_Vehiculo_Servicio,
                ID_Servicio = vehiculoServicio.ID_Servicio,
                ID_Vehiculo = vehiculoServicio.ID_Vehiculo,
                Servicios = new Servicio
                {
                    ID_Servicio = vehiculoServicio.Servicios.ID_Servicio,
                    Descripcion = vehiculoServicio.Servicios.Descripcion,
                    Monto = vehiculoServicio.Servicios.Monto
                },
                Vehiculo = new Carro
                {
                    ID_Vehiculo = vehiculoServicio.Vehiculo.ID_Vehiculo,
                    Placa = vehiculoServicio.Vehiculo.Placa,
                    Dueño = vehiculoServicio.Vehiculo.Dueño,
                    Marca = vehiculoServicio.Vehiculo.Marca
                }
                
            };
        }
    }
}