using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //public string Index()
        //{
        //    return "Hello World";
        //}
        //public string Welcome(string name,int numTimes = 1 ) 
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTime is: {numTimes}");
        //}

        public IActionResult Index() 
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["name"]=name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
