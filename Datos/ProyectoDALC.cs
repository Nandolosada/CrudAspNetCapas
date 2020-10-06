using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class ProyectoDALC
    {
        public List<Proyecto> ListarProyectos()
        {
            using (var db = new ProyectosContext())
            {
                return db.Proyecto.ToList();

            }
        }

        public void Agregar(Proyecto proyecto) {
            using (var db = new ProyectosContext())
            {
                db.Proyecto.Add(proyecto);
                db.SaveChanges();
            }
        }

       


    }
}
