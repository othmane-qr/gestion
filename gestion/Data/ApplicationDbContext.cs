using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using gestion.Models;

namespace gestion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<gestion.Models.Etudiant> Etudiant { get; set; }
        public DbSet<gestion.Models.Roles> Roles { get; set; }
    }
}
