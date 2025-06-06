using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    public IActionResult MyData()
    {
        DataClass Obj = new DataClass();

        MyDataViewModel myDataViewModel = new MyDataViewModel();
        myDataViewModel.Datas = Obj.GetData();


        return View(myDataViewModel);
    }
}
