using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Domain.Entities;
public class Project
{
    public int ProjectID { get; set; }
    public string ProjectName { get; set; } = string.Empty;

    // Navigation property
    public List<ProjectSection> Sections { get; set; } = new List<ProjectSection>();
}