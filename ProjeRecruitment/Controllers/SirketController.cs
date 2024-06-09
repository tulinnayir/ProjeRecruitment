using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProjeRecruitment.Controllers
{
    public class SirketController : Controller
    {
        CompaniesManager um = new CompaniesManager(new EfCompaniesDal());
        JobAdvertsManager jm = new JobAdvertsManager(new EfJobAdvertsDal());
        AdressesManager ay = new AdressesManager(new EfAdressesDal());
        AppDbContext context = new AppDbContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SirketProfil()
        {
            if (HttpContext.Session.GetString("mail") == null)
            {
                return RedirectToAction("SirketProfil", "Sirket");
            }

            ViewBag.mail = HttpContext.Session.GetString("mail");
            ViewBag.fax_phone = HttpContext.Session.GetString("fax_phone");
            ViewBag.id = HttpContext.Session.GetInt32("id");
            ViewBag.phone = HttpContext.Session.GetString("phone");
            ViewBag.tax_no = HttpContext.Session.GetString("tax_no");
            ViewBag.explanation = HttpContext.Session.GetString("explanation");
            ViewBag.company_title = HttpContext.Session.GetString("company_title");

            return View();
        }

        [HttpPost]
        public IActionResult SirketProfil(Companies companies)
        {
            string result = "";

            var bilgi = context.Companies.FirstOrDefault(x => x.mail == companies.mail);
            if (bilgi != null)
            {
                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(companies.password, bilgi.password);

                if (isPasswordValid)
                {
                    HttpContext.Session.SetInt32("id", bilgi.id);
                    HttpContext.Session.SetString("company_title", bilgi.company_title);
                    HttpContext.Session.SetString("mail", bilgi.mail);
                    HttpContext.Session.SetString("fax_phone", bilgi.fax_phone);
                    HttpContext.Session.SetString("phone", bilgi.phone);
                    HttpContext.Session.SetString("tax_no", bilgi.tax_no);
                    HttpContext.Session.SetString("explanation", bilgi.explanation);

                    return RedirectToAction("SirketProfil", "Sirket");
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
        public IActionResult SirketProfilUpdate(JobAdverts p)
        {
            //var update = jm.GetByID(p.id);

            //update.title = p.title;
            //update.description = p.description;
            //update.type_of_work = p.type_of_work;
            //update.Position = p.Position;
            //update.JobLocation = p.JobLocation;
            //update.Level = p.Level;
            //update.Department = p.Department;
            //update.Department = p.Department;

            //um.CompaniesUpdate(update);
            return RedirectToAction("SirketProfil");
        }

        [HttpGet]
        public IActionResult SirketUyelik()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SirketUyelik(Companies p)
        {
            if (p.mail == null)
            {
                return View("SirketUyelik");
            }
            else
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(p.password);
                p.password = hashedPassword;
                um.CompaniesAdd(p);
                TempData["SuccessMessage"] = "Kayıt başarılı!";

                return RedirectToAction("SirketUyelik");
            }
        }

        [HttpGet]
        public IActionResult IlanAc()
        {
            if (HttpContext.Session.GetString("mail") == null)
            {
                return RedirectToAction("SirketUyelik", "Sirket");
            }

            return View();
        }

        [HttpPost]
        public IActionResult IlanAc(JobAdverts p)
        {
            if (HttpContext.Session.GetString("mail") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            if (p.title == null)
            {
                ViewBag.ErrorMessage = "Başlık boş olamaz.";
                return View("IlanAc");
            }
            else
            {
                p.company_id = 1;
                jm.JobAdvertsAdd(p);
                TempData["SuccessMessage"] = "Kayıt başarılı!";
                return RedirectToAction("SirketProfil");
            }
        }

        public IActionResult SirketIlanlarim()
        {
            var query = context.JobAdverts
                              .Include(u => u.JobSkills)
                              .Include(u => u.JobApplications)
                              .ToList();

            return View(query);
        }







        [HttpGet]
        public IActionResult SirketAdayGoruntulemeDetay(string ISTUR, string YETKINLIK, string ALTKATEGOR, string Beg, string Ju, string Mid, string Exper, string Expert)
        {
            var isturList = string.IsNullOrEmpty(ISTUR) ? new List<int>() : ISTUR.Split(',').Select(int.Parse).ToList();
            var yetkinlikList = string.IsNullOrEmpty(YETKINLIK) ? new List<int>() : YETKINLIK.Split(',').Select(int.Parse).ToList();
            var altKategoriList = string.IsNullOrEmpty(ALTKATEGOR) ? new List<int>() : ALTKATEGOR.Split(',').Select(int.Parse).ToList();

            var begList = string.IsNullOrEmpty(Beg) ? new List<int>() : Beg.Split(',').Select(int.Parse).ToList();
            var juList = string.IsNullOrEmpty(Ju) ? new List<int>() : Ju.Split(',').Select(int.Parse).ToList();
            var midList = string.IsNullOrEmpty(Mid) ? new List<int>() : Mid.Split(',').Select(int.Parse).ToList();
            var experList = string.IsNullOrEmpty(Exper) ? new List<int>() : Exper.Split(',').Select(int.Parse).ToList();
            var expertList = string.IsNullOrEmpty(Expert) ? new List<int>() : Expert.Split(',').Select(int.Parse).ToList();

            var query = context.Users
                                .Include(u => u.Adresses)
                                .Include(u => u.UserSkills)
                                .AsQueryable();

            if (isturList.Count > 0)
            {
                query = query.Where(u => u.UserSkills.Any(us => us.JobTypes != null && isturList.Contains(us.JobTypes.id)));
            }

            if (yetkinlikList.Count > 0)
            {
                query = query.Where(u => u.UserSkills.Any(us => us.Competencies != null && yetkinlikList.Contains(us.Competencies.id)));
            }

            if (altKategoriList.Count > 0)
            {
                query = query.Where(u => u.UserSkills.Any(us => us.Categories != null && altKategoriList.Contains(us.Categories.id)));
            }

            var usersWithRelatedData = query.ToList();

            if (begList.Count > 0 || juList.Count > 0 || midList.Count > 0 || experList.Count > 0 || expertList.Count > 0)
            {
                // Verilen puanları al ve hepsini tek bir listeye koy
                var allScores = begList.Concat(juList).Concat(midList).Concat(experList).Concat(expertList).ToList();

                // Kullanıcıları filtrele ve puanlarını hesapla
                var filteredUsers = usersWithRelatedData
                    .Select(u => new
                    {
                        User = u,
                        ClosestScore = u.UserSkills
                            .Where(us => int.TryParse(us.level_score, out _))
                            .Select(us => int.Parse(us.level_score))
                            .Select(level => new
                            {
                                Level = level,
                                ClosestDiff = allScores.Select(score => Math.Abs(score - level)).Min()
                            })
                            .OrderBy(l => l.ClosestDiff)
                            .ThenByDescending(l => l.Level)
                            .FirstOrDefault()?.Level ?? 0
                    })
                    .OrderByDescending(u => u.ClosestScore) // En yakın puandan en düşüğe sırala
                    .Select(u => u.User)
                    .ToList();

                return View(filteredUsers);
            }

            return View(usersWithRelatedData); // Parametreler yoksa tüm verileri getir
        }







    }
}
