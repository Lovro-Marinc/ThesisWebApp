using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Domain.Entities;


[Table("Project", Schema = "dbo")]
public class Project
{
    [Key]
    public int ProjectID { get; set; }
    [StringLength(255)]
    public string ProjectName { get; set; } = string.Empty;

    // Navigation property
    public List<ProjectSection> Sections { get; set; } = new List<ProjectSection>();
}