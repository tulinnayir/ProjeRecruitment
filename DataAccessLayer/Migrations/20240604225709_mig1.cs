using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distirct_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    adresses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address_id = table.Column<int>(type: "int", nullable: true),
                    company_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax_phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.id);
                    table.ForeignKey(
                        name: "FK_Companies_Adresses_address_id",
                        column: x => x.address_id,
                        principalTable: "Adresses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    address_id = table.Column<int>(type: "int", nullable: true),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_birth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    school_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                    table.ForeignKey(
                        name: "FK_Users_Adresses_address_id",
                        column: x => x.address_id,
                        principalTable: "Adresses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "JobAdverts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_id = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    advert_end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type_of_work = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MilitaryStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobAdverts", x => x.id);
                    table.ForeignKey(
                        name: "FK_JobAdverts_Companies_company_id",
                        column: x => x.company_id,
                        principalTable: "Companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usersid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.id);
                    table.ForeignKey(
                        name: "FK_JobTypes_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    job_id = table.Column<int>(type: "int", nullable: true),
                    job_app_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.id);
                    table.ForeignKey(
                        name: "FK_JobApplications_JobAdverts_job_id",
                        column: x => x.job_id,
                        principalTable: "JobAdverts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JobApplications_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Competencies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    job_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competencies", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competencies_JobApplications_job_id",
                        column: x => x.job_id,
                        principalTable: "JobApplications",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    competence_id = table.Column<int>(type: "int", nullable: true),
                    Usersid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Categories_Competencies_competence_id",
                        column: x => x.competence_id,
                        principalTable: "Competencies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Categories_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "JobSkills",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_type_id = table.Column<int>(type: "int", nullable: true),
                    compet_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    jobadvert_id = table.Column<int>(type: "int", nullable: true),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    min_level_score = table.Column<int>(type: "int", nullable: false),
                    max_level_score = table.Column<int>(type: "int", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobSkills", x => x.id);
                    table.ForeignKey(
                        name: "FK_JobSkills_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JobSkills_Competencies_compet_id",
                        column: x => x.compet_id,
                        principalTable: "Competencies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JobSkills_JobAdverts_jobadvert_id",
                        column: x => x.jobadvert_id,
                        principalTable: "JobAdverts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JobSkills_JobTypes_job_type_id",
                        column: x => x.job_type_id,
                        principalTable: "JobTypes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JobSkills_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_type_id = table.Column<int>(type: "int", nullable: true),
                    compet_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Beg = table.Column<int>(type: "int", nullable: true),
                    Ju = table.Column<int>(type: "int", nullable: true),
                    Mid = table.Column<int>(type: "int", nullable: true),
                    Exper = table.Column<int>(type: "int", nullable: true),
                    Expert = table.Column<int>(type: "int", nullable: true),
                    level_score = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserSkills_Categories_category_id",
                        column: x => x.category_id,
                        principalTable: "Categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_UserSkills_Competencies_compet_id",
                        column: x => x.compet_id,
                        principalTable: "Competencies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_UserSkills_JobTypes_job_type_id",
                        column: x => x.job_type_id,
                        principalTable: "JobTypes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_UserSkills_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_competence_id",
                table: "Categories",
                column: "competence_id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Usersid",
                table: "Categories",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_address_id",
                table: "Companies",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Competencies_job_id",
                table: "Competencies",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobAdverts_company_id",
                table: "JobAdverts",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_job_id",
                table: "JobApplications",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobApplications_user_id",
                table: "JobApplications",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_category_id",
                table: "JobSkills",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_compet_id",
                table: "JobSkills",
                column: "compet_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_job_type_id",
                table: "JobSkills",
                column: "job_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_jobadvert_id",
                table: "JobSkills",
                column: "jobadvert_id");

            migrationBuilder.CreateIndex(
                name: "IX_JobSkills_Usersid",
                table: "JobSkills",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_JobTypes_Usersid",
                table: "JobTypes",
                column: "Usersid");

            migrationBuilder.CreateIndex(
                name: "IX_Users_address_id",
                table: "Users",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_category_id",
                table: "UserSkills",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_compet_id",
                table: "UserSkills",
                column: "compet_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_job_type_id",
                table: "UserSkills",
                column: "job_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_user_id",
                table: "UserSkills",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobSkills");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Competencies");

            migrationBuilder.DropTable(
                name: "JobApplications");

            migrationBuilder.DropTable(
                name: "JobAdverts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
