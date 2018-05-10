using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace ActionAuthorization.Context
{
    public class ActionAuthorizationContext:DbContext
    {
        public ActionAuthorizationContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var asm = Assembly.GetExecutingAssembly();
            var typs = asm.GetTypes().Where(p => typeof(IEntityTypeConfiguration<>).IsAssignableFrom(p) && p.FullName.EndsWith("Map"));
            foreach (dynamic item in typs)
            {
                modelBuilder.ApplyConfiguration(item);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
