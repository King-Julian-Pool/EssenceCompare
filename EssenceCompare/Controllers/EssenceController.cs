using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EssenceCompare.Controllers
{
    public class EssenceController : Controller
    {
        // 
        // GET: /Essence/

        public IActionResult Index()
        {
            return View();
        }
    }
}
