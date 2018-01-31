using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AppActivosFijosWJCQ.Entity.Model;

namespace AppActivosFijosWJCQ.Entity
{
    /// <summary>
    /// Contexto de base de datos
    /// </summary>
    public class ActivosFijosContext:DbContext
    {
        /// <summary>
        /// Activos Fijos Context Constructor
        /// </summary>
        public ActivosFijosContext(): base("name=db")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<ActivosFijos> ActivosFijos { get; set; }
        public DbSet<AreaPersona> AreaPersona { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<EstadoActual> EstadoActual { get; set; }

        /// <summary>
        /// Fluent Api
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <remarks>NA</remarks>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<AreaPersona>()
                           .HasMany<Ciudad>(c => c.Ciudad)
                           .WithMany(c => c.AreaPersona)
                           .Map(cs =>
                           {
                               cs.MapLeftKey("Id_AreaPersona");
                               cs.MapRightKey("Id_Ciudad");
                               cs.ToTable("AreaPersona_Ciudad");
                               
                           });

                modelBuilder.Entity<ActivosFijos>().
                HasRequired<AreaPersona>(s => s.AreaPersona)
                .WithMany(g => g.ActivosFijos)
                .HasForeignKey<int>(x => x.Id_EstadoActual);

            modelBuilder.Entity<ActivosFijos>().
            HasRequired<EstadoActual>(s => s.EstadoActual)
            .WithMany(g => g.ActivosFijos)
            .HasForeignKey<int>(x => x.Id_AreaPersona);

            //base.OnModelCreating(modelBuilder);
        }
    }
}
