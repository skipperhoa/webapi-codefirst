namespace WebAPI_CodeFistEntityFramework.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    public partial class dbEntities : DbContext
    {
        public dbEntities()
            : base("name=dbEntities")
        {
        }
        public DbSet<Student> Students { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         
        }
    }
}
