using _11WEEKHOMEWORK.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11WEEKHOMEWORK.Controllers
{
    public class KategorilerController : Controller
    {
        List<Kategoriler> Kategoris;

        public KategorilerController()
        {
            Kategoris=[
                new Kategoriler{KategoriAdı="1. Kategori",ResimUrl="https://picsum.photos/id/237/200/300"},
                new Kategoriler{KategoriAdı="2. Kategori",ResimUrl="https://picsum.photos/id/238/200/300"},
                new Kategoriler{KategoriAdı="3. Kategori",ResimUrl="https://picsum.photos/id/239/200/300"}
                
            ];
        }
        public ActionResult Kategoriler()
        {
            ViewData["KategorilerList"]=Kategoris;
            return View();
        }

    }
}
