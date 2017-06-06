using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Entity.Data
{
    public class ApplicationDbContextFactory:IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create(DbContextFactoryOptions options)
        {
            var builderOption = new DbContextOptionsBuilder<ApplicationDbContext>();
            builderOption.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFSeparate;Integrated Security=True;");


            return new ApplicationDbContext(builderOption.Options);
        }
    }
}
