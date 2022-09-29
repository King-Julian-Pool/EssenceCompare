using EssenceCompare.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EssenceCompare.Controllers
{
    public class EssenceController : Controller
    {
        // 
        // GET: /Essence/

        public  async Task<IActionResult> Index()
        {
            List<PrixEssence?>? prixEssences =  await ApiGetter.GetEssence();

            ViewData["prixEssences"] = prixEssences;
            
            return View();            
        }
    }
}
