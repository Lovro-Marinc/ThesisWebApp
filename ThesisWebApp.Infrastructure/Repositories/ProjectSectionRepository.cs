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
    public Task AddAsync(ProjectSection projectSection)
    {
        throw new NotImplementedException();
    }
}
