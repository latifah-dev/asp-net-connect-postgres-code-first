using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Models;
using CodeFirst.Models.Entities;

namespace CodeFirst.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CobaDbContext _dbContext;

    public HomeController(ILogger<HomeController> logger , CobaDbContext dbContext)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Barang> barangs = _dbContext.Barangs.ToList();
        
        return View(barangs);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Barang Bar)
    {
            Bar.IdPenjual =2;
            _dbContext.Barangs.Add(Bar);
            _dbContext.SaveChanges();
            return Redirect("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
