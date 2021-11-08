using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCClinica.Data;
using MVCClinica.Models;
using MVCClinica.Filters;

namespace MVCClinica.Controllers
{
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            return View("Index", AdminMedico.Listar()); 
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create", AdminMedico.Crear()); 
        }

        [MiFiltro]
        [HttpPost]
        public ActionResult Create(Medico medico)
        {
           if(ModelState.IsValid)
            {
                AdminMedico.AgregarABase(medico);
                return RedirectToAction("Index");
            }
            return View("Create", medico); 
        }

        public ActionResult Detail(int id)
        {
            Medico m = AdminMedico.encontrarMedico(id); 
            if(m != null)
            {
                return View("Detail", m); 
            }
            else
            {
                return HttpNotFound(); 
            }
        }

        public ActionResult SearchByEspecialidad(string especialidad)
        {
            if (especialidad == "")
            {
                return RedirectToAction("Index");
            }
            List<Medico> medicos = AdminMedico.traerMedicosPorEspecialidad(especialidad);
            return View("Index", medicos);
        }

        public ActionResult Delete(int id)
        {
            Medico m = AdminMedico.encontrarMedico(id);
            if (m != null)
            {
                return View("Delete", m);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico m = AdminMedico.encontrarMedico(id);
            AdminMedico.eliminarMedico(m); 
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Medico m = AdminMedico.encontrarMedico(id); 
            if (m != null)
            {
                return View("Edit", m);
            }
            else
            {
                return HttpNotFound();
            }
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult EditConfirmed(Medico m)
        {
            if (ModelState.IsValid)
            {
                AdminMedico.modificar(m); // TODO no anda
                return RedirectToAction("Index");
            }
            return View("Edit", m);
        }

        public ActionResult SearchByNombreApellido(string nombre, string apellido)
        {
            if (nombre == "" && apellido == "")
            {
                return RedirectToAction("Index");
            }
            List<Medico> medicos = AdminMedico.traerMedicosPorNombreCompleto(nombre, apellido);
            return View("Index", medicos);
        }
    }
}