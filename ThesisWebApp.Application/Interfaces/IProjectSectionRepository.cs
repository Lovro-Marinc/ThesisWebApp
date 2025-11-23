using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWebApp.Domain.Entities;

namespace ThesisWebApp.Application.Interfaces;
public interface IProjectSectionRepository
{
    Task AddAsync(ProjectSection projectSection);
    Task<List<ProjectSection>> GetAllAsync();
    Task<List<ProjectSection>> GetByProjectIdAsync(int projectId);
    Task<ProjectSection?> GetByIdAsync(int sectionId);
    Task UpdateAsync(ProjectSection projectSection);
    Task DeleteByIdAsync(int id);

}
