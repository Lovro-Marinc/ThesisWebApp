using ThesisWebApp.Domain.Entities;

namespace ThesisWebApp.WebUi.State;

public class SelectionService
{
    private Project? _selectedProject;

    public Project? SelectedProject
    {
        get => _selectedProject;
        private set
        {
            _selectedProject = value;
            OnSelectedProjectChanged?.Invoke();
        }
    }

    public event Action? OnSelectedProjectChanged;

    public void SetSelectedProject(Project project)
    {
        SelectedProject = project;
    }
}