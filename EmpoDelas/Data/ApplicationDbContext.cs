using empodelas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmpoDelas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autonoma> Autonoma { get; set; }

        public DbSet<Afiliada> Afiliada { get; set; }

        public DbSet<ProdutoServico> ProdutoServico { get; set; }

        public DbSet<Afiliacao> Afiliacao { get; set; }
    }
}
