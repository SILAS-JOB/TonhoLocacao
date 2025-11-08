using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Iana;
using TonhoLocacao.Models;
using TonhoLocacao.Services;

namespace TonhoLocacao.Controllers;


public class HomeController : Controller
{
    private readonly PdfService _pdfService;
    public HomeController(PdfService pdfService)
    {
        _pdfService = pdfService;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult StartPdfService()
    {
        byte[] pdfData = _pdfService.GeneratePdf();
        return File(pdfData, "application/pdf", "Seu_Orçamento.pdf");
    } 

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
