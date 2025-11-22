using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Domain.Entities;
public class ProjectSection
{
    public int SectionID { get; set; }
    public int ProjectID { get; set; }
    public string SectionName { get; set; } = string.Empty;
    public string SheetName { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    // Navigation properties
    public Project Project { get; set; } = null!;
    public List<Component> Components { get; set; } = new List<Component>();
}