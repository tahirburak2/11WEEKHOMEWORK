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
                
                return RedirectToAction("Index", "Home");
            }

            return View("Index"); // Eğer doğrulama hatalıysa formu tekrar göster
        }

    }
}
