using Microsoft.AspNetCore.Mvc;

namespace _11WEEKHOMEWORK.Controllers
{
    public class IletişimController : Controller
    {

        public ActionResult Iletisim()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Submit()
        {
            if (ModelState.IsValid)
            {
                // Formu işleyin, ardından Home sayfasına yönlendirin.
                return RedirectToAction("Index", "Home"); // HomeController'daki Index'e yönlendirme
            }

            return View("Index"); // Eğer doğrulama hatalıysa formu tekrar göster
        }

    }
}
