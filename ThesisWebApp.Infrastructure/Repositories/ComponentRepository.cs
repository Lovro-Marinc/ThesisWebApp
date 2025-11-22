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
public class ComponentRepository : IComponentRepository
{
    private readonly SandboxContext _sandboxContext;
    public ComponentRepository(IDbContextFactory<SandboxContext> sandboxContext)
    {
        _sandboxContext = sandboxContext.CreateDbContext();
    }
    public Task AddAsync(Component component)
    {
        throw new NotImplementedException();
    }
}
