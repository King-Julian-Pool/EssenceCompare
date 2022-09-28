using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace EssenceCompare.Controllers
{
    public class EssenceController : Controller
    {
        // 
        // GET: /Essence/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Essence/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
