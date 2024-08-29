using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employment.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users_tbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wishedJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    howFind = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeMeli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MahaleSodor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meliat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Din = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AfradTafakol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isSingle = table.Column<bool>(type: "bit", nullable: false),
                    ChildNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isTobacco = table.Column<bool>(type: "bit", nullable: false),
                    Sarbazi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovahiRanandegi = table.Column<bool>(type: "bit", nullable: false),
                    phoneSabet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneSos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherStudy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoterJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherStudy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rel1Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel1Rel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel1Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel1Study = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel2Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel2Rel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel2Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rel2Study = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    friendFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friendRel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friendJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    friendPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studylvl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyScholl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyFinish = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyScore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isStuding = table.Column<bool>(type: "bit", nullable: false),
                    study2History = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    study2lvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    study2Scholl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    study2Finish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    study2Score = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    englishConv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    englishWrite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    englishUndrestand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    langName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LangConv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    langWrite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    langUnderstand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    corse1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    corse1Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    corse2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    corse2Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft1lvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft2lvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft3Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soft3lvl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobPay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjobReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2End = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Pay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exjob2Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Points = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isWorking = table.Column<bool>(type: "bit", nullable: false),
                    canDorKari = table.Column<bool>(type: "bit", nullable: false),
                    canZemanat = table.Column<bool>(type: "bit", nullable: false),
                    haveSopishine = table.Column<bool>(type: "bit", nullable: false),
                    isFullTime = table.Column<bool>(type: "bit", nullable: false),
                    startDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rezomePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users_tbl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users_tbl");
        }
    }
}
