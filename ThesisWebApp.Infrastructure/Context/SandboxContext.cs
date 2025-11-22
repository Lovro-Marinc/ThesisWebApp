using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWebApp.Domain.Entities;

namespace ThesisWebApp.Infrastructure.Data;
public class SandboxContext : DbContext
{
    public SandboxContext(DbContextOptions<SandboxContext> options) : base(options)
    {

    }
    public DbSet<Component> Components { get; set; }
    public DbSet<ProjectSection> ProjectSections { get; set; }
    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>()
            .HasMany(p => p.Sections)
            .WithOne(s => s.Project)
            .HasForeignKey(s => s.ProjectID);

        modelBuilder.Entity<ProjectSection>()
            .HasMany(s => s.Components)
            .WithOne(c => c.Section)
            .HasForeignKey(c => c.SectionID);

        base.OnModelCreating(modelBuilder);
    }

}
