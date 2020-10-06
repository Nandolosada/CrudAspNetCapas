using Entidad;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Proyectos_ASP.net_Capas.Controllers
{
    public class ProyectoController : Controller
    {
        // GET: Proyecto
        public ActionResult Index()
        {
            var proyectos = ProyectoCN.ListarProyectos();
            return View(proyectos);
        }
        
        [HttpGet]
        public ActionResult Crear() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Proyecto proyecto)
        {
            try
            {
                if (proyecto.NombreProyecto == null)
                {
                    return Json(new { ok = false, msg = "Debe ingresar el nombre del proyecto" }, JsonRequestBehavior.AllowGet);
                }
                
                System.Threading.Thread.Sleep(1000);

                ProyectoCN.Agregar(proyecto);
                return Json(new { ok = true, toRedirect = "Index" }, JsonRequestBehavior.AllowGet);

                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { ok = false, msg = ex.Message}, JsonRequestBehavior.AllowGet);
                //ModelState.AddModelError("","Ocurrio un error al agregar un proyecto");
                //return View();
            }

        }
    }
}