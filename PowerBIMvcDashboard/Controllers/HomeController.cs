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

        string reportUrl = "https://app.powerbi.com/reportEmbed?reportId=04122f37-5cd4-482a-94b3-8d21c5ff5cc5&autoAuth=true&ctid=d826664f-15b5-465e-b789-65c3c61e69ee";// from "Publish to Web"
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
