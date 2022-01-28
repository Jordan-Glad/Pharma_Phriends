using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pharma_Phriends.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pharma_Phriends.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<RxDrug> RxDrugs { get; set;}
        public DbSet<Price> Prices { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext(DbSet<RxDrug>RxDrugs)
        {
        }

        public ApplicationDbContext()
        {
        }
    }
}
