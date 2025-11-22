using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Domain.Entities;

public class Component
{
    public int ComponentID { get; set; }
    public int SectionID { get; set; }
    public string Position { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal? Quantity { get; set; }
    public string? Unit { get; set; }
    public decimal? SupplyPerUnit { get; set; }
    public decimal? InstallationPerUnit { get; set; }
    public decimal? TotalPerUnit { get; set; }
    public decimal? Total { get; set; }
    public int SortOrder { get; set; }

    // Navigation property
    public ProjectSection Section { get; set; } = null!;
}