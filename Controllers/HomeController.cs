using Microsoft.AspNetCore.Mvc;

namespace StudentLearningHub.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Error() => Content("An error occurred.");
}
