using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PimUrbanGreen.Models;

namespace PimUrbanGreen.Controllers;

public class IndexController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
