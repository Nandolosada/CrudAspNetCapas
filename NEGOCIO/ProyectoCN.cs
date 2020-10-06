using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace NEGOCIO
{
    public class ProyectoCN
    {
        private static ProyectoDALC obj = new ProyectoDALC();
        public static List<Proyecto> ListarProyectos() 
        {
            return obj.ListarProyectos();
        }

        public static void Agregar(Proyecto proyecto) {
            obj.Agregar(proyecto);
        }
    }
}
