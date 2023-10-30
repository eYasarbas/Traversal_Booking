using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Booking.Controllers;

public class PdfReportController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult StaticPdfReport()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/PdfReports/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);
        var document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        document.Open();
        var paragraph = new Paragraph("Traversal Reservation Pdf Report");
        document.Add(paragraph);
        document.Close();
        return File("/PdfReports/dosya1.pdf",
            "application/pdf", "dosya1.pdf");
    }

    public IActionResult StaticCustomerReport()
    {
        var path = Path.Combine(Directory.GetCurrentDirectory(),
            "wwwroot/PdfReports/" + "dosya1.pdf");
        var stream = new FileStream(path, FileMode.Create);
        var document = new Document(PageSize.A4);
        PdfWriter.GetInstance(document, stream);
        document.Open();
        PdfPTable pdfPTable = new PdfPTable(3);
        pdfPTable.AddCell("Guest Name");
        pdfPTable.AddCell("Guest SurName");
        pdfPTable.AddCell("Guest TC");
        pdfPTable.AddCell("Deneme1");
        pdfPTable.AddCell("Deneme1");
        pdfPTable.AddCell("12345618901");
        pdfPTable.AddCell("Deneme2");
        pdfPTable.AddCell("Deneme2");
        pdfPTable.AddCell("12345628901");
        pdfPTable.AddCell("Deneme3");
        pdfPTable.AddCell("Deneme3");
        pdfPTable.AddCell("12345638901");
        document.Add(pdfPTable);
        document.Close();
        return File("/PdfReports/dosya2.pdf",
            "application/pdf", "dosya2.pdf");
    }
}