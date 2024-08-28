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


    public IActionResult Index(int id = 1)
    {
        var check = dbs.Users_tbl
            .OrderByDescending(x=>x.Id)
            .ToList();
        ViewBag.Count = (int)Math.Ceiling((double)check.Count/10);
        ViewBag.allCount = check.Count;
        check = check.Skip((id-1)*10)
            .Take(10).ToList();

        ViewBag.Users = check;
        ViewBag.page = id;
        return View();
    }
    public IActionResult remove(int id){
        dbs.Users_tbl.Remove(dbs.Users_tbl.Find(id));
        dbs.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Show(int id){
        var check = dbs.Users_tbl.Find(id);
        ViewBag.data = check;
        return View();
    }

}