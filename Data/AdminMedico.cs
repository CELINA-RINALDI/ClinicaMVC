using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace MVCClinica.Data
{
    public static class AdminMedico
    {
        private static ClinicaDbContext context = new ClinicaDbContext();
        public static List<Medico> Listar()
        {
            return context.Medicos.ToList(); 
        }

        public static Medico Crear()
        {
            return new Medico();
        }

        public static void AgregarABase(Medico m)
        {
            context.Medicos.Add(m);
            context.SaveChanges();
        }

        internal static Medico encontrarMedico(int id)
        {
          Medico medico = context.Medicos.Find(id);
            context.Entry(medico).State = EntityState.Detached;
            return medico;
        }

        internal static void eliminarMedico(Medico m)
        {
            context.Medicos.Remove(m);
            context.SaveChanges();
        }

        internal static void modificar(Medico m)
        {
            context.Medicos.Attach(m);
            context.SaveChanges();
        }

        internal static List<Medico> traerMedicosPorEspecialidad(string especialidad)
        {
            var medicos = (from m in context.Medicos
                           where m.Especialidad == especialidad
                           select m).ToList();
            return medicos; 
        }

        internal static List<Medico> traerMedicosPorNombreCompleto(string nombre, string apellido)
        {
            var medicos = (from m in context.Medicos
                           where m.Nombre == nombre && m.Apellido == apellido
                           select m).ToList();
            return medicos;
        }
    }
}