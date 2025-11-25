using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisWebApp.Application.Interfaces;

namespace ThesisWebApp.Infrastructure.Services;
public class ExcelExport : IExcelExport
{
    public byte[] ExportReport()
    {
        var workbook = new ExcelFile();
        var sheet = workbook.Worksheets.Add("Sheet1");
        sheet.Cells["A1"].Value = "Hello World!";

        using var stream = new MemoryStream();
        workbook.Save(stream, SaveOptions.XlsxDefault);
        return stream.ToArray();
    }
}

