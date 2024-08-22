using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;
using myPortfolio.DAL.Entities;

namespace myPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList() // deneyim listesini çağırdık
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet] //sayfa yüklendiğinde çalışacak
        public IActionResult CreateExperience() // yeni deneyim ekleme
        {
            return View();
        }

        [HttpPost] // sayfada bir butona tıklandığında çalışıcak
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience); //parametreden gönderdiğim değeri contextte experience içine ekle
            context.SaveChanges(); //değişiklikleri kaydet
            return RedirectToAction("ExperienceList"); //beni ExperienceList metoduna döndür
        }

        public IActionResult DeleteExperience(int id) // deneyim silme işlemi yukardakiyle benzer adımlar
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet] 
        public IActionResult UpdateExperience(int id) //burda güncelleme için deneyimi çağırdık
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience) //burda değişimi yapmamızı sağladık
        { 
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
