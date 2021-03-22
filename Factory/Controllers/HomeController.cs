using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;
    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      var engineers = _db.Engineers.ToList();
      var machines = _db.Machines.ToList();
      Dictionary<string, object> model = new Dictionary<string, object> {};
      model.Add("engineers", engineers);
      model.Add("machines", machines);
      return View(model);
    }

  }
}