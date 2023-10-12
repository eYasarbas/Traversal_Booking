using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Traversal_Booking.Models;

namespace Traversal_Booking.Controllers;

public class ExcelController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public List<DestinationModel> DestinationLists()
    {
        var destinationModels = new List<DestinationModel>();
        using (var c = new Context())
        {
            destinationModels = c.Destinations.Select(x => new DestinationModel
            {
                Ctiy = x.Ctiy,
                DayNight = x.DayNight,
                Price = x.Price,
                Capacity = x.Capacity
            }).ToList();
        }

        ;
        return destinationModels;
    }

    public IActionResult StaticExcelReport()
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

            return File(bytes,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "dosya2.xlsx");
        }
    }

    public IActionResult DestinationExcelReport()
    {
        using (var workBook = new XLWorkbook())
        {
            var workSheet = workBook.Worksheets.Add("Tour List");
            workSheet.Cell(1, 1).Value = "City";
            workSheet.Cell(1, 2).Value = "Duration of Stay";
            workSheet.Cell(1, 3).Value = "Price";
            workSheet.Cell(1, 4).Value = "Capacity";

            var rowCount = 2;
            foreach (var item in DestinationLists())
            {
                workSheet.Cell(rowCount, 1).Value = item.Ctiy;
                workSheet.Cell(rowCount, 2).Value = item.DayNight;
                workSheet.Cell(rowCount, 3).Value = item.Price;
                workSheet.Cell(rowCount, 4).Value = item.Capacity;
                rowCount++;
            }

            using (var stream = new MemoryStream())
            {
                workBook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content,
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "newList.xlsx");
            }
        }
    }
}