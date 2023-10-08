using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wsApi.Models;

namespace wsApi.Db
{
    public class context : DbContext
    {

        public context(DbContextOptions<context> options): base (options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }
    }
}
