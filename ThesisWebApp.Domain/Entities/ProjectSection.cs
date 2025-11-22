using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Domain.Entities;
[Table("ProjectSection", Schema = "dbo")]
public class ProjectSection
{
    [Key]
    public int SectionID { get; set; }
    [ForeignKey("ProjectID")]
    public int ProjectID { get; set; }
    [StringLength(255)]
    public string SectionName { get; set; } = string.Empty;
    [StringLength(255)]
    public string SheetName { get; set; } = string.Empty;
    public int SortOrder { get; set; }

    // Navigation properties
    public Project Project { get; set; } = null!;
    public List<Component> Components { get; set; } = new List<Component>();
}