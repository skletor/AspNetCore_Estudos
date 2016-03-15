using Microsoft.AspNet.Mvc;

namespace MinimalMvc.Controllers{
    
    public class HomeController : Controller{

        public ActionResult Index(){
            ViewBag.MsgWelcome = "Hello Welcome";
            return View();
        }
        
    }
    
    
}