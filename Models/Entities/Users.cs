using System.ComponentModel.DataAnnotations;

public class Users
{
    [Key]
    public int Id { get; set; }
    public string wishedJob { get; set; }
    public string howFind { get; set; }
    public string FirstName { get; set; }//
    public string LastName { get; set; }//
    public string FatherName { get; set; }
    public string CodeMeli { get; set; }//
    public string MahaleSodor { get; set; }//
    public string BirthDay { get; set; }//
    public string Meliat { get; set; }//
    public string Din { get; set; }//
    public string AfradTafakol { get; set; }//
    public bool isSingle { get; set; }//
    public string ChildNum { get; set; }//
    public bool isTobacco { get; set; } // دخانیات
    public string Sarbazi { get; set; }//
    public bool GovahiRanandegi { get; set; }//
    public string phoneSabet { get; set; }//
    public string phone { get; set; }//
    public string phoneSos { get; set; }//
    public string? Email { get; set; }//
    public string Address { get; set; }//
    public string FatherFullName { get; set; }//
    public string FatherJob { get; set; }//
    public string FatherStudy { get; set; }//
    public string MotherFullName { get; set; }//
    public string MoterJob { get; set; }//
    public string MotherStudy { get; set; }//
    public string? rel1Fullname { get; set; }//
    public string? rel1Rel { get; set; } // ریلیشن رابط 1
    public string? rel1Job { get; set; }//
    public string? rel1Study { get; set; }//
    public string? rel2Fullname { get; set; }
    public string? rel2Rel { get; set; } // ریلیشن رابط 2
    public string? rel2Job { get; set; }
    public string? rel2Study { get; set; }
    public string friendFullName { get; set; }//
    public string friendRel { get; set; }//
    public string friendJob { get; set; }//
    public string friendPhone { get; set; }//
    public string studyHistory { get; set; }//
    public string studylvl { get; set; }//
    public string studyScholl { get; set; }//
    public string studyFinish { get; set; }//
    public string studyScore { get; set; }//
    public bool isStuding { get; set; }//
    public string? study2History { get; set; }//
    public string? study2lvl { get; set; }//
    public string? study2Scholl { get; set; }//
    public string? study2Finish { get; set; }//
    public string? study2Score { get; set; }//
    public string englishConv { get; set; }//
    public string englishWrite { get; set; }//
    public string englishUndrestand { get; set; }//
    public string? langName { get; set; }//
    public string? LangConv { get; set; }//
    public string? langWrite { get; set; }//
    public string? langUnderstand { get; set; }//
    // دوره ها
    public string? corse1Name { get; set; }//
    public string? corse1Time { get; set; }//
    public string? corse2Name { get; set; }//
    public string? corse2Time { get; set; }//
    // نرم افزار ها
    public string? soft1Name { get; set; }//
    public string? soft1lvl { get; set; }//
    public string? soft2Name { get; set; }//
    public string? soft2lvl { get; set; }//
    public string? soft3Name { get; set; }//
    public string? soft3lvl { get; set; }//
    // سوابق کاری
    public string? exjobCompany { get; set; }//
    public string? exjobName { get; set; }//
    public string? exjobStart { get; set; }//
    public string? exjobEnd { get; set; }//
    public string? exjobPay { get; set; }//
    public string? exjobPhone { get; set; }//
    public string? exjobReason { get; set; }//
    public string? exjob2Company { get; set; }//
    public string? exjob2Name { get; set; }//
    public string? exjob2Start { get; set; }//
    public string? exjob2End { get; set; }//
    public string? exjob2Pay { get; set; }//
    public string? exjob2Phone { get; set; }//
    public string? exjob2Reason { get; set; }//
    // سوالات
    public string Points { get; set; }//
    public string Bime { get; set; }//
    public bool isWorking { get; set; }
    public bool canDorKari { get; set; }//
    public bool canZemanat { get; set; }//
    public bool haveSopishine { get; set; } //
    public bool isFullTime { get; set; }//
    public string startDate { get; set; } //
    public string payment { get; set; } //
    public string? rezomePath { get; set; }
    public DateTime CreateDateTime { get; set; }
}