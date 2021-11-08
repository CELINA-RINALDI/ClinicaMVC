using MVCClinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCClinica.Data
{
    public class ClinicaDbContext: DbContext 
    {
        public ClinicaDbContext() : base("KeyDB") { }
        public DbSet<Medico> Medicos { get; set; }

    }
}