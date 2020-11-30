using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendedores.Models;

namespace Vendedores.Data
{
    public class VendedoresContext : DbContext
    {
        public VendedoresContext (DbContextOptions<VendedoresContext> options)
            : base(options)
        {
        }

        public DbSet<Vendedores.Models.Departamento> Departamento { get; set; }
    }
}
