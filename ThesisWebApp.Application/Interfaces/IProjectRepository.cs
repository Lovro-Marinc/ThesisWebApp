using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWebApp.Domain.Entities;

namespace ThesisWebApp.Application.Interfaces;
public interface IProjectRepository
{
    Project? SelectedProject { get; }
    event Action? OnSelectedProjectChanged;
    void SetSelectedProject(Project project);
    Task<List<Project>> GetAllAsync();

}
