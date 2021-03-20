using Factory.Models;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   return View(_db.Machines.ToList());
    // }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    // public ActionResult Create()
    // {
    //   ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
    //   return View();
    // }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Machine machine)
    {
      if (ModelState.IsValid)
      {  
        DateTime now = DateTime.Now;
        machine.InstallationDate = now;
        _db.Machines.Add(machine);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(machine);
    }

    public ActionResult Details(int id)
    {
      var thisMachine = _db.Machines
          .Include(machine => machine.JoinEntities)
          .ThenInclude(join => join.Engineer)
          .FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

    public ActionResult Edit(int id)
    {
      var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
      return View(thisMachine);
    }

  }
}