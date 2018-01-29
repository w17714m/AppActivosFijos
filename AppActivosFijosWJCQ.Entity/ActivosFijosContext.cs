using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AppActivosFijosWJCQ.Entity.Model;

namespace AppActivosFijosWJCQ.Entity
{
    public class ActivosFijosContext:DbContext
    {
        public ActivosFijosContext(): base("name=db")
        {
        }
        public DbSet<ActivosFijos> ActivosFijos { get; set; }
        public DbSet<AreaPersona> AreaPersona { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<EstadoActual> EstadoActual { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AreaPersona>()
                           .HasMany<Ciudad>(c => c.Ciudad)
                           .WithMany(c => c.AreaPersona)
                           .Map(cs =>
                           {
                               cs.MapLeftKey("Id_AreaPersona");
                               cs.MapRightKey("Id_Ciudad");
                               cs.ToTable("AreaPersona_Ciudad");
                               
                           });


            //base.OnModelCreating(modelBuilder);
        }
    }
}
