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

public class ProjectRepository : IProjectRepository
{
    private readonly SandboxContext _sandboxContext;
    public ProjectRepository(IDbContextFactory<SandboxContext> sandboxContext)
    {
        _sandboxContext = sandboxContext.CreateDbContext();
    }
    private Project? _selectedProject;

    public Project? SelectedProject => _selectedProject;

    public event Action? OnSelectedProjectChanged;

    public void SetSelectedProject(Project project)
    {
        _selectedProject = project;
        OnSelectedProjectChanged?.Invoke();
    }

    public async Task<List<Project>> GetAllAsync()
    {
        var projects = await _sandboxContext.Projects.ToListAsync();
        return projects;
    }
}
