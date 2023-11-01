using BusinessLayer.Abstract;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace BusinessLayer.Concrete;

public class ExcelManager : IExcelService
{
    public byte[] ExcelList<T>(List<T> t) where T : class
    {
        var package = new ExcelPackage();
        var workSheet = package.Workbook.Worksheets.Add("Page1");
        workSheet.Cells["A1"].LoadFromCollection(t, true,
            TableStyles.Light10);
        return package.GetAsByteArray();
    }
}