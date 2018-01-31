using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TVZPitalica.DAL.Entities
{
    public class PitalicaDBContext : DbContext
    {
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestResult> TestResult { get; set; }
        public virtual DbSet<User> User { get; set; }

        public PitalicaDBContext(DbContextOptions<PitalicaDBContext> options)
        : base(options)
        { }
    }
}
