using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Traversal_Booking.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var excel = new ExcelPackage(new FileInfo("dosya1.xlsx")))
            {
                var workSheet = excel.Workbook.Worksheets.Add("Page1");
                workSheet.Cells[1, 1].Value = "Route";
                workSheet.Cells[1, 2].Value = "Guide";
                workSheet.Cells[1, 3].Value = "Quota";
                workSheet.Cells[2, 1].Value = "Paris";
                workSheet.Cells[2, 2].Value = "Jamalia";
                workSheet.Cells[2, 3].Value = "50";
                excel.Save();

                var bytes = excel.GetAsByteArray();

                return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "dosya1.xlsx");
            }
        }
    }
}
