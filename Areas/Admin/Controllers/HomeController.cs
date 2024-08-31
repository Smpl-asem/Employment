using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace test.Areas.Admin.Controllers;

[Area("Admin")]
public class HomeController : Controller
{
    private readonly context dbs;

    private readonly IWebHostEnvironment _env;
    public HomeController(context _db, IWebHostEnvironment env)
    {
        _env = env;
        dbs = _db;
    }


    public IActionResult Subs(int? Subs , int id = 1)
    {
        List<Users>? check;

        if(Subs.HasValue){
            check = dbs.Users_tbl
            .OrderByDescending(x => x.Id)
            .Include(x=>x.department)
            .Where(x=>x.departmentId == Subs)
            .ToList();
        }
        else{
            check = dbs.Users_tbl
            .Include(x=>x.department)
            .OrderByDescending(x => x.Id)
            .ToList();
        }

        ViewBag.Count = (int)Math.Ceiling((double)check.Count / 10);
        ViewBag.allCount = check.Count;
        check = check.Skip((id - 1) * 10)
            .Take(10).ToList();

        ViewBag.Users = check;
        ViewBag.page = id;
        return View();
    }
    public IActionResult remove(int id)
    {
        var check = dbs.Users_tbl.Find(id);
        dbs.Users_tbl.Remove(check);
        dbs.SaveChanges();
        return RedirectToAction("Subs", new { id = check.departmentId });
    }
    public IActionResult Show(int id)
    {
        var check = dbs.Users_tbl.Find(id);
        ViewBag.data = check;
        return View();
    }
    public IActionResult Index(int id = 1)
    {
        var check = dbs.Jobs_tbl
            .OrderByDescending(x => x.Id)
            .Include(x=>x.Subs)
            .ToList();
        ViewBag.Count = (int)Math.Ceiling((double)check.Count / 10);
        ViewBag.allCount = check.Count;
        check = check.Skip((id - 1) * 10)
            .Take(10).ToList();

        ViewBag.Jobs = check;

        var check2 = dbs.Users_tbl.ToList();
        ViewBag.data = check2;

        ViewBag.page = id;
        return View();
    }

    public IActionResult addDepartment()
    {
        return View();
    }

    [HttpPost]
    public IActionResult addDepartment(string Name)
    {
        if (!dbs.Jobs_tbl.Any(x => x.Name.ToLower() == Name.ToLower()))
        {
            dbs.Jobs_tbl.Add(new JobDepartment
            {
                Name = Name
            });
            dbs.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    public IActionResult RemoveDepartment(int id)
    {
        dbs.Jobs_tbl.Remove(dbs.Jobs_tbl.Find(id));
        dbs.SaveChanges();

        return RedirectToAction("Index");
    }
}