using System;
using Microsoft.EntityFrameworkCore;
namespace DataLayer
{
    public class Class1CustemerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("data source=.; initial catalog=CustomerData; UID=IT410Saleuser PWD=IT410Salespwd;");
        }
    }
}
