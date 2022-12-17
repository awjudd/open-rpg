using Microsoft.AspNetCore.Mvc;

namespace OpenRPG.API.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
}