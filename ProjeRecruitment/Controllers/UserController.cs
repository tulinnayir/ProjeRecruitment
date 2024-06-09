using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProjeRecruitment.Controllers
{
    public class UserController : Controller
    {
        UsersManager um = new UsersManager(new EfUsersDal());
        JobAdvertsManager jm = new JobAdvertsManager(new EfJobAdvertsDal());
      

        AppDbContext db = new AppDbContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserProfil()

        {
            if (HttpContext.Session.GetString("name") == null)
            {
                return RedirectToAction("UserUyelik", "User");
            }

            var userName = HttpContext.Session.GetString("name");
            var userSurname = HttpContext.Session.GetString("surname");
            var userId = HttpContext.Session.GetInt32("id");
            var userMail = HttpContext.Session.GetString("mail");
            var userPhone = HttpContext.Session.GetString("phone");
            var userDateOfBirth = HttpContext.Session.GetString("dateOfBirth");
            var userSchoolName = HttpContext.Session.GetString("schoolName");
            var userJobName = HttpContext.Session.GetString("jobName");
            var userNote = HttpContext.Session.GetString("note");
            var userMajor = HttpContext.Session.GetString("major");
            var userStartDate = HttpContext.Session.GetString("startDate");
            var userEndDate = HttpContext.Session.GetString("endDate");
            var userGender = HttpContext.Session.GetString("gender");
            var userExplanation = HttpContext.Session.GetString("explanation");


            ViewBag.UserName = userName;
            ViewBag.UserSurname = userSurname;
            ViewBag.UserId = userId;
            ViewBag.UserMail = userMail;
            ViewBag.UserPhone = userPhone;
            ViewBag.UserDateOfBirth = userDateOfBirth;
            ViewBag.UserSchoolName = userSchoolName;
            ViewBag.UserJobName = userJobName;
            ViewBag.UserNote = userNote;
            ViewBag.UserMajor = userMajor;
            ViewBag.UserStartDate = userStartDate;
            ViewBag.UserEndDate = userEndDate;
            ViewBag.UserGender = userGender;
            ViewBag.UserExplanation = userExplanation;

            return View();
        }


        public IActionResult UserIlan()
        {
            var query = db.JobAdverts
                             .Include(u => u.JobSkills)
                             .Include(u => u.JobApplications).
                             ToList();

            return View(query);
        }

        [HttpGet]
        public IActionResult UserUyelik()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserProfil(Users users)
        {
            string result = "";
            var bilgi = db.Users.FirstOrDefault(x => x.mail == users.mail);
            if (bilgi != null)
            {
                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(users.password, bilgi.password);
                if (isPasswordValid)
                {
                    HttpContext.Session.SetInt32("id", bilgi.id);
                    HttpContext.Session.SetString("name", bilgi.name);
                    HttpContext.Session.SetString("surname", bilgi.surname);
                    // Yeni bilgileri de oturumda sakla
                    HttpContext.Session.SetString("mail", bilgi.mail);
                    HttpContext.Session.SetString("phone", bilgi.phone);
                    HttpContext.Session.SetString("dateOfBirth", bilgi.date_birth?.ToString("yyyy-MM-dd"));
                    HttpContext.Session.SetString("schoolName", bilgi.school_name);
                    HttpContext.Session.SetString("jobName", bilgi.job_name);
                    HttpContext.Session.SetString("note", bilgi.note);
                    HttpContext.Session.SetString("major", bilgi.major);
                    HttpContext.Session.SetString("startDate", bilgi.start_date?.ToString("yyyy-MM-dd"));
                    HttpContext.Session.SetString("endDate", bilgi.end_date?.ToString("yyyy-MM-dd"));
                    HttpContext.Session.SetString("gender", bilgi.gender);
                    HttpContext.Session.SetString("explanation", bilgi.explanation);

                    return RedirectToAction("UserProfil", "User");
                }
                else
                {
                    result = "Şifre Hatalı";
                }
            }
            else
            {
                result = "Kullanıcı Hatalı";
            }

            ViewBag.Message = result;
            return View();
        }

        [HttpPost]
        public IActionResult UserInsert(Users p)
        {
            if (p.name == null)
            {
                return View("UserUyelik");
            }
            else
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(p.password);
                p.address_id = 1;
                p.password = hashedPassword;
                um.UsersAdd(p);
                TempData["SuccessMessage"] = "Kayıt başarılı!";
                return RedirectToAction("UserUyelik");
            }
        }

        [HttpPost]
        public IActionResult UserProfilUpdate(Users p)
        {
            int? userId = HttpContext.Session.GetInt32("id");
            if (userId == null)
            {
                return RedirectToAction("UserUyelik", "User");
            }

            var update = um.GetByID(userId.Value); // Giriş yapan kullanıcının bilgilerini al
            if (update == null)
            {
                // Kullanıcı bulunamazsa bir hata sayfasına yönlendirme veya hata mesajı gösterme işlemi yapılabilir
                return RedirectToAction("ErrorPage", "Error");
            }

            // Kullanıcı bilgilerini güncelle (null kontrolü ekleyerek)
            if (p.explanation != null) update.explanation = p.explanation;
            if (p.phone != null) update.phone = p.phone;
            if (p.date_birth != null) update.date_birth = p.date_birth;
            if (p.school_name != null) update.school_name = p.school_name;
            if (p.job_name != null) update.job_name = p.job_name;
            if (p.note != null) update.note = p.note;
            if (p.major != null) update.major = p.major;
            if (p.gender != null) update.gender = p.gender;

            um.UsersUpdate(update); // Güncellenen kullanıcı bilgilerini veritabanına kaydet

            return RedirectToAction("UserProfil", "User"); // Profil sayfasına yönlendir
        }
    }

}
