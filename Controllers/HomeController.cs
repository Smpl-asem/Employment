using System.Data.Common;
using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
{
    private readonly context db;
    private readonly IWebHostEnvironment _env;
    public HomeController(context _db, IWebHostEnvironment env)
    {
        db = _db;
        _env = env;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(DtoUser user)
    {
        if (!db.Users_tbl.Any(x => x.CodeMeli == user.CodeMeli))
        {
            db.Users_tbl.Add(new Users
            {
                Address = user.Address,
                AfradTafakol = user.AfradTafakol,
                Bime = user.Bime,
                BirthDay = user.BirthDay,
                canDorKari = user.canDorKari,
                canZemanat = user.canZemanat,
                ChildNum = user.ChildNum,
                CodeMeli = user.CodeMeli,
                corse1Name = user.corse1Name,
                corse1Time = user.corse1Time,
                corse2Name = user.corse2Name,
                corse2Time = user.corse2Time,
                CreateDateTime = DateTime.UtcNow,
                Din = user.Din,
                Email = user.Email,
                englishConv = user.englishConv,
                englishUndrestand = user.englishUndrestand,
                englishWrite = user.englishWrite,
                exjob2Company = user.exjob2Company,
                exjob2End = user.exjob2End,
                exjob2Name = user.exjob2Name,
                exjob2Pay = user.exjob2Pay,
                exjob2Phone = user.exjob2Phone,
                exjob2Reason = user.exjob2Reason,
                exjob2Start = user.exjob2Start,
                exjobCompany = user.exjobCompany,
                exjobEnd = user.exjobEnd,
                exjobName = user.exjobName,
                exjobPay = user.exjobPay,
                exjobPhone = user.exjobPhone,
                exjobReason = user.exjobReason,
                exjobStart = user.exjobStart,
                FatherFullName = user.FatherFullName,
                FatherJob = user.FatherJob,
                FatherName = user.FatherName,
                FatherStudy = user.FatherStudy,
                FirstName = user.FirstName,
                friendFullName = user.friendFullName,
                friendJob = user.friendJob,
                friendPhone = user.friendPhone,
                friendRel = user.friendRel,
                GovahiRanandegi = user.GovahiRanandegi,
                haveSopishine = user.haveSopishine,
                howFind = user.howFind,
                isFullTime = user.isFullTime,
                isSingle = user.isSingle,
                isStuding = user.isStuding,
                isTobacco = user.isTobacco,
                isWorking = user.isWorking,
                LangConv = user.LangConv,
                langName = user.langName,
                langUnderstand = user.langUnderstand,
                langWrite = user.langWrite,
                LastName = user.LastName,
                MahaleSodor = user.MahaleSodor,
                Meliat = user.Meliat,
                MoterJob = user.MoterJob,
                MotherFullName = user.MotherFullName,
                MotherStudy = user.MotherStudy,
                payment = user.payment,
                phone = user.phone,
                phoneSabet = user.phoneSabet,
                phoneSos = user.phoneSos,
                Points = user.Points,
                rel1Fullname = user.rel1Fullname,
                rel1Job = user.rel1Job,
                rel1Rel = user.rel1Fullname,
                rel1Study = user.rel1Study,
                rel2Fullname = user.rel2Fullname,
                rel2Job = user.rel2Job,
                rel2Rel = user.rel2Rel,
                rel2Study = user.rel2Study,
                rezomePath = user.rezome == null ? null : await patherAsync(user.rezome),
                Sarbazi = user.Sarbazi,
                soft1lvl = user.soft1lvl,
                soft1Name = user.soft1Name,
                soft2lvl = user.soft2lvl,
                soft2Name = user.soft2Name,
                soft3lvl = user.soft3lvl,
                soft3Name = user.soft3Name,
                startDate = user.startDate,
                study2Finish = user.study2Finish,
                study2History = user.study2History,
                study2lvl = user.study2lvl,
                study2Scholl = user.study2Scholl,
                study2Score = user.study2Score,
                studyFinish = user.studyFinish,
                studyHistory = user.studyHistory,
                studylvl = user.studylvl,
                studyScholl = user.studyScholl,
                studyScore = user.studyScore,
                wishedJob = user.wishedJob
            });
            db.SaveChanges();
            ViewBag.Result = "درخواست با موفقیت ارسال شد ، منتظر تماس ما باشید";
            return View();
        }
        else
        {
            ViewBag.error = "شما قبلا تلاش کردید";
            return View();
        }
    }
    private async Task<string> patherAsync(IFormFile file)
    {
        string FileExtension = Path.GetExtension(file.FileName);
        var NewFileName = String.Concat(Guid.NewGuid().ToString(), FileExtension);
        var uploadsDirectory = $"{_env.WebRootPath}/uploads";

        // بررسی وجود دایرکتوری، در صورت عدم وجود، آن را ایجاد کنید  
        if (!Directory.Exists(uploadsDirectory))
        {
            Directory.CreateDirectory(uploadsDirectory);
        }
        var path = $"{_env.WebRootPath}/uploads/{NewFileName}";
        var PathSave = $"/uploads/{NewFileName}";
        using (var stream = new FileStream(path, FileMode.Create))
        {
            await file.CopyToAsync(stream);
        }
        return PathSave;
    }
}
