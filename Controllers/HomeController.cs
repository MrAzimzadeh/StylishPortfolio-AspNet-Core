using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;
    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var header = _context.Headers.FirstOrDefault();
        var CallAction = _context.CallActions.FirstOrDefault();
        var Callout = _context.Callouts.FirstOrDefault();
        var portfolio = _context.Portfolios.ToList();
        var services = _context.Services.ToList();
        var about = _context.Abouts.FirstOrDefault();
        HomeVM homeVM = new HomeVM(){
            Headers = header, 
            Portfolios = portfolio,
            Services = services , 
            About = about
        };
        return View(homeVM);
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