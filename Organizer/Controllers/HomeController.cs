using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using Organizer.Models;
using Organizer.Services;
using System.Diagnostics;

namespace Organizer.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGraphClientService _graphClientService;
        private GraphServiceClient graphServiceClient;

        public HomeController(ILogger<HomeController> logger, IGraphClientService graphClientService)
        {
            _logger = logger;
            _graphClientService = graphClientService;
            graphServiceClient = _graphClientService.GetGraphServiceClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}