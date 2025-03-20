using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
