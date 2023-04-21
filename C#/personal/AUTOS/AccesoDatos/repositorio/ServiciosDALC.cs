using AccesoDatos.baseDeDatos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.fabrica;

namespace AccesoDatos
{
   public  class ServiciosDALC
    {
     
   

        public void Agregar(Servicio Serv)
        {

            using (var db = new AUTOSEntities())
            {
                db.Servicios.Add(ServiciosFabrica.GetServicio(Serv));

                db.SaveChanges();

            }
        }

        public List<Servicio> ListarServicios()
        {
            List<Servicios> list = null;
            List<Servicio> list2 = new List<Servicio>();
            using (var db = new AUTOSEntities())
            {
                list=  db.Servicios.ToList();
            }

            foreach (var item in list)
            {
                list2.Add(ServiciosFabrica.GetServicio(item));
            }
            return list2;
        }


        public Servicio GetServicios(int id)
        {

            using (var db = new AUTOSEntities())
            {
                return ServiciosFabrica.GetServicio( db.Servicios.Find(id) );

            }
        }


        public void Editar(Servicio Serv)
        {

            using (var db = new AUTOSEntities())
            {
                var d = db.Servicios.Find(Serv.ID_Servicio);
                d.Monto = Serv.Monto;
                d.Descripcion = Serv.Descripcion;
          
                db.SaveChanges();

            }
        }



        public void Borrar(int id)
        {

            using (var db = new AUTOSEntities())
            {

                var Serv = db.Servicios.Find(id);
                db.Servicios.Remove(Serv);
                db.SaveChanges();


            }
        }



    }
}
