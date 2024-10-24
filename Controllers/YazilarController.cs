using _11WEEKHOMEWORK.Models;
using Microsoft.AspNetCore.Mvc;

namespace _11WEEKHOMEWORK.Controllers
{
    public class YazilarController : Controller
    {
        List<Blog> Blogs;

        public YazilarController()
        {
            Blogs = [
                new Blog{Baslik="1. blogumuz",Ozet="1. Bloğun Özeti",ResimUrl="https://picsum.photos/id/237/200/300"},

                new Blog{Baslik="2. blogumuz",Ozet="2. Bloğun Özeti",ResimUrl="https://picsum.photos/id/238/200/300"},

                new Blog{Baslik="3. blogumuz",Ozet="3. Bloğun Özeti",ResimUrl="https://picsum.photos/id/239/200/300"},

                new Blog{Baslik="4. blogumuz",Ozet="4. Bloğun Özeti",ResimUrl="https://picsum.photos/id/230/200/300"},
                new Blog{Baslik="5. blogumuz",Ozet="5. Bloğun Özeti",ResimUrl="https://picsum.photos/id/231/200/300"},

                new Blog{Baslik="6. blogumuz",Ozet="6. Bloğun Özeti",ResimUrl="https://picsum.photos/id/232/200/300"},

                new Blog{Baslik="7. blogumuz",Ozet="7. Bloğun Özeti",ResimUrl="https://picsum.photos/id/233/200/300"},

                new Blog{Baslik="8. blogumuz",Ozet="8. Bloğun Özeti",ResimUrl="https://picsum.photos/id/234/200/300"},
                
                new Blog{Baslik="9. blogumuz",Ozet="9. Bloğun Özeti",ResimUrl="https://picsum.photos/id/235/200/300"},

                new Blog{Baslik="10. blogumuz",Ozet="10. Bloğun Özeti",ResimUrl="https://picsum.photos/id/236/200/300"},
                new Blog{Baslik="11. blogumuz",Ozet="11. Bloğun Özeti",ResimUrl="https://picsum.photos/id/126/200/300"},
                new Blog{Baslik="12. blogumuz",Ozet="12. Bloğun Özeti",ResimUrl="https://picsum.photos/id/216/200/300"}
            ];
        }
        public ActionResult Yazilar()
        {
            ViewData["BlogList"]=Blogs;
            return View();
        }

    }
}
