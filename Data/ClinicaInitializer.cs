using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public class ClinicaInitializer : DropCreateDatabaseAlways<ClinicaDbContext>
    {
        protected override void Seed(ClinicaDbContext context)
        {
            var medicos = new List<Medico>
            {
                new Medico
                {
                    Nombre = "Juan",
                    Apellido = "Fernandez",
                    NroMatricula = 12345,
                    Especialidad= "Pediatria"
                }
            };
            medicos.ForEach(s => context.Medicos.Add(s));
            context.SaveChanges(); 
        }

    }
}