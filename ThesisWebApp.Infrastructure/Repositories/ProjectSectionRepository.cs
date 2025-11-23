using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWebApp.Application.Interfaces;
using ThesisWebApp.Domain.Entities;
using ThesisWebApp.Infrastructure.Data;

namespace ThesisWebApp.Infrastructure.Repositories;
public class ProjectSectionRepository : IProjectSectionRepository
{
    private readonly SandboxContext _sandboxContext;
    public ProjectSectionRepository(IDbContextFactory<SandboxContext> sandboxContext)
    {
        _sandboxContext = sandboxContext.CreateDbContext();
    }
    public async Task AddAsync(ProjectSection projectSection)
    {
        _sandboxContext.ProjectSections.Add(projectSection);
        await _sandboxContext.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var section = await GetByIdAsync(id);
        if (section != null)
        {
            _sandboxContext.ProjectSections.Remove(section);
            await _sandboxContext.SaveChangesAsync();
        }
    }

    public async Task<List<ProjectSection>> GetAllAsync()
    {
        var projectSections = await _sandboxContext.ProjectSections.ToListAsync();
        return projectSections;
    }

    public async Task<ProjectSection?> GetByIdAsync(int sectionId)
    {
        var section = await _sandboxContext.ProjectSections
            .FirstOrDefaultAsync(ps => ps.SectionID == sectionId);
        return section;
    }

    public async Task<List<ProjectSection>> GetByProjectIdAsync(int projectId)
    {
        var section = await _sandboxContext.ProjectSections
            .Where(ps => ps.ProjectID == projectId)
            .ToListAsync();
        return section;
    }

    public async Task UpdateAsync(ProjectSection projectSection)
    {
        _sandboxContext.Entry(projectSection).State = EntityState.Modified;
        await _sandboxContext.SaveChangesAsync();
    }
}
