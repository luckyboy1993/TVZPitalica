using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TVZPitalica.DAL.Entities
{
    public class PitalicaDBContext : DbContext
    {
        public virtual DbSet<Answer> AddressType { get; set; }
        public virtual DbSet<Question> AwbuildVersion { get; set; }
        public virtual DbSet<Test> BillOfMaterials { get; set; }
        public virtual DbSet<TestResult> BusinessEntity { get; set; }
        public virtual DbSet<User> BusinessEntityAddress { get; set; }

        public PitalicaDBContext(DbContextOptions<PitalicaDBContext> options)
        : base(options)
        { }
    }
}
