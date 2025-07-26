using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PowerBIMvcDashboard.Models;

namespace PowerBIMvcDashboard.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //return View();

        string reportUrl = "https://app.powerbi.com/view?r=eyJrIjoiYWI4NzE1MGYtOTNhMi00MzhjLWJiN2ItMTE3ZjM4NGJiZThhIiwidCI6ImQ4MjY2NjRmLTE1YjUtNDY1ZS1iNzg5LTY1YzNjNjFlNjllZSIsImMiOjN9"; // from "Publish to Web"
        ViewBag.ReportUrl = reportUrl;
        ViewBag.RefreshInterval = 60000; // 5 minutes in milliseconds
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
