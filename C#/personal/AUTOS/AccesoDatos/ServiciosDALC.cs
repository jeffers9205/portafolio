using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
   public  class ServiciosDALC
    {


        public void Agregar(Servicios Serv)
        {

            using (var db = new masterEntities())
            {
                db.Servicios.Add(Serv);

                db.SaveChanges();

            }
        }

        public List<Servicios> ListarServicios()
        {
            using (var db = new masterEntities())

                return db.Servicios.ToList();
        }


        public Servicios GetServicios(int id)
        {

            using (var db = new masterEntities())
            {
                return db.Servicios.Find(id);

            }
        }


        public void Editar(Servicios Serv)
        {

            using (var db = new masterEntities())
            {
                var d = db.Servicios.Find(Serv.ID_Servicio);
                d.Monto = Serv.Monto;
                d.Descripción = Serv.Descripción;
          
                db.SaveChanges();

            }
        }



        public void Borrar(int id)
        {

            using (var db = new masterEntities())
            {

                var Serv = db.Servicios.Find(id);
                db.Servicios.Remove(Serv);
                db.SaveChanges();


            }
        }



    }
}
