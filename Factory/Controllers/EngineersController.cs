using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(_db.Engineers.OrderBy(m=>m.EngineerName).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer engineer)
    {
      if (ModelState.IsValid)
      {
        DateTime now = DateTime.Now;
        engineer.HireDate = now;
        _db.Engineers.Add(engineer);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(engineer);
    }

    public ActionResult Details(int id)
    {
      var thisEngineer = _db.Engineers
          .Include(engineer => engineer.JoinEntities)
          .ThenInclude(join => join.Machine)
          .FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    public ActionResult Edit(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult Edit(Engineer engineer)
    {
      if (ModelState.IsValid)
      {
        _db.Entry(engineer).State = EntityState.Modified;
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(engineer);
    }

    public ActionResult Delete(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      return View(thisEngineer);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      _db.Engineers.Remove(thisEngineer);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddMachine(int id)
    {
      var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
      ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "MachineName");
      return View(thisEngineer);
    }

    [HttpPost]
    public ActionResult AddMachine(Engineer engineer, int machineId)
    {
      bool matches = _db.EngineerMachine.Any(x => x.EngineerId == engineer.EngineerId && x.MachineId == machineId);
      if(!matches && ModelState.IsValid)
      {
        if (machineId != 0)
        {
          _db.EngineerMachine.Add(new EngineerMachine() { MachineId = machineId, EngineerId = engineer.EngineerId });
        }
      }
      _db.Entry(engineer).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteMachine(int joinId)
    {
      var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
      _db.EngineerMachine.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public async Task<IActionResult> Search(string searchString)
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName");
      var search = from m in _db.Engineers
        select m;

      if (!String.IsNullOrEmpty(searchString))
      {
        search = search.Where(s => s.EngineerName.Contains(searchString));
        return View(await Task.FromResult(search.ToList()));
      }
      else
      {
        List<Engineer> model = _db.Engineers.ToList();
        return View(_db.Engineers.OrderBy(m=>m.EngineerName).ToList());
      }
    }

    public ActionResult CertLevel()
    {
      ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "EngineerName", "EngineerCerts");
      return View(_db.Engineers.OrderByDescending(m=>m.EngineerCerts).ToList());
    }

  }
}