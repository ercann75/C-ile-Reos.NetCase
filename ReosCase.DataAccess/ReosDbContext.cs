using Microsoft.EntityFrameworkCore;
using ReosCase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReosCase.DataAccess
{
    public class ReosDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-CNBG28J\\ERCAN; Database=ReosCaseDb; uid=erc; pwd=123; TrustServerCertificate=True;");

        }
        public DbSet<Product> Products { get; set; }
    }
}
