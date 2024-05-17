using Microsoft.AspNetCore.Mvc;
using Zadanie.Models;
using Zadanie.Services.Interfaces;

public class OsobyController : Controller
{
    private readonly IOsosbyServices _services;

    public OsobyController(IOsosbyServices ososbyServices)
    {
        _services = ososbyServices;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult add(Osoby osoba)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", osoba);
        }

        _services.Save(osoba);
        return View("Index");
    }

    [HttpGet]
    public IActionResult showAll()
    {
        var osoby = _services.GetAll();
        return View(osoby);
    }

    [HttpGet]
    public IActionResult showById(int id)
    {
        var ososba = _services.GetById(id);
        return View("Index", ososba);
    }
}
