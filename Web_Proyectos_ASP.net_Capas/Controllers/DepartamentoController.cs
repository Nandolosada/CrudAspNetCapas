using Entidad;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web_Proyectos_ASP.net_Capas.Controllers
{
    public class DepartamentoController : Controller
    {
        // GET: Departamento

        [HttpGet] //Peticion que se realiza al servidor
        public ActionResult Index()
        {
            var dptos = DepartamentoCN.ListarDepartamentos();
            return View(dptos);
        }

        [HttpGet] //Peticion que se realiza al servidor
        public ActionResult Crear() {

            return View();
        }

        [HttpPost] //Cuando se envia informacion a el servidor
        public ActionResult Crear(Departamento dpto) {
            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("", "Debe de ingresar un departamento");
                    return View(dpto);
                }
                DepartamentoCN.Agregar(dpto);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("","Ocurrio un error al agregar un departamento");
                return View(dpto);
            }         
           
        }
        public ActionResult GetDepartamento(int id) {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);        
        }

        public ActionResult Editar(int id) {
            var dpto = DepartamentoCN.GetDepartamento(id);
            return View(dpto);
        }

        [HttpPost]
        public ActionResult Editar(Departamento dpto) {

            try
            {
                if (dpto.NombreDepartamento == null)
                {
                    ModelState.AddModelError("","Debe ingresar un Nombre de Departamento");
                    return View(dpto);
                }
                
                DepartamentoCN.Editar(dpto);
                return RedirectToAction("Index");

            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Ocurrio un error al editar un departamento");
                return View(dpto);
            }

        }


        public ActionResult Eliminar(int? id) {

            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var dpto = DepartamentoCN.GetDepartamento(id.Value);
            return View(dpto);
        }

        [HttpPost]
        public ActionResult Eliminar(int id) {
            try
            {
                DepartamentoCN.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Ocurrio un error al eliminar un departamento");
                return View();
            }
        }

    }
}