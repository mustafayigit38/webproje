using Fihris.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fihris.Controllers
{
    public class PersonController : Controller
    {
        public FihrisContext Context { get; set; }
        public PersonController()
        {
            Context = new FihrisContext();
        }
        public IActionResult Index()
        {
            var liste = Context.People.ToList();
            return View(liste);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([FromForm]Person p) 
        {
            if(ModelState.IsValid)
            {
                Context.People.Add(p);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }
    }
}
