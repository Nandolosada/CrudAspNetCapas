﻿using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DepartamentoDALC
    {
        public List<Departamento> ListarDepartamentos()
        {
            using (var db= new ProyectosContext())
            {
                return db.Departamento.ToList();
            }           
        }

        public void Agregar(Departamento dpto) {
            using (var db = new ProyectosContext())
            {
                db.Departamento.Add(dpto);
                db.SaveChanges();
            }
        }

        public Departamento GetDEpartamento(int id) {
            using (var db = new ProyectosContext() )
            {
                return db.Departamento.Find(id);
               // return db.Departamento.Where(d => d.DepartamentoId == id).FirstOrDefault();
            }        
        }

        public void Editar(Departamento dpto) {
            using (var db =  new ProyectosContext())
            {
                var d = db.Departamento.Find(dpto.DepartamentoId);
                d.NombreDepartamento = dpto.NombreDepartamento;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id) {
            using (var db = new ProyectosContext()) {
                var dpto = db.Departamento.Find(id);
                db.Departamento.Remove(dpto);
                db.SaveChanges();
            }

        }

    }
}
