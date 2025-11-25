using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisWebApp.Application.Interfaces;
public interface IExcelExport
{
    byte[] ExportReport();
}
