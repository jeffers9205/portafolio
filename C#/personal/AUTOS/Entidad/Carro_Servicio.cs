
namespace Entidad
{
    using System;
    using System.Collections.Generic;
    
    public class Carro_Servicio
    {
        public int ID_Vehiculo_Servicio { get; set; }
        public int ID_Servicio { get; set; }
        public int ID_Vehiculo { get; set; }
    
        public  Servicio Servicios { get; set; }
        public  Carro Vehiculo { get; set; }
    }
}
