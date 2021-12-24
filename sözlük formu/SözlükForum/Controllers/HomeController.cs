using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SözlükForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Localization;

namespace SözlükForum.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly IHtmlLocalizer<HomeController> _localizer;



        public HomeController(ILogger<HomeController> logger, IHtmlLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }
        Contex c = new Contex();


        public IActionResult Index(string searchString)
        {
            var bilgi = c.ForumSorus.Include(i => i.kullanici);
            var bilgiler = c.ForumSorus.OrderBy(r => Guid.NewGuid()).Take(5);
            ViewData["gundem"] = bilgiler;
            if (!String.IsNullOrEmpty(searchString))
            {
                bilgi = c.ForumSorus.Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici);
                var bilgibil = c.ForumSorus.Where(x => x.soru.Contains(searchString)).Include(i => i.kullanici).Count();
                if (bilgibil == 0)
                {
                    bilgi = null;
                }
            }
            return View(bilgi);
        }

        public IActionResult IndexKato(int id,string searchString)
        {
            switch (id)
            {
                case 1:
                    var bilgi1 = c.ForumSorus.Where(x => x.katego == Katego.Spor).Include(i => i.kullanici);
                    var bilgi1c = c.ForumSorus.Where(x => x.katego == Katego.Spor).Include(i => i.kullanici).Count();
                    if(bilgi1c == 0)
                    {
                        bilgi1 = null;
                    }
                    var bilgiler1 = c.ForumSorus.Where(x => x.katego == Katego.Spor).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler1;
                    return View(bilgi1);

                case 2:
                    var bilgi2 = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).Include(i => i.kullanici);
                    var bilgi2c = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).Include(i => i.kullanici).Count();
                    if (bilgi2c == 0)
                    {
                        bilgi2 = null;
                    }
                    var bilgiler2 = c.ForumSorus.Where(x => x.katego == Katego.Ekonomi).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler2;
                    return View(bilgi2);
                case 3:
                    var bilgi3 = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).Include(i => i.kullanici);
                    var bilgi3c = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).Include(i => i.kullanici).Count();
                    if (bilgi3c == 0)
                    {
                        bilgi3 = null;
                    }
                    var bilgiler3 = c.ForumSorus.Where(x => x.katego == Katego.Sağlık).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler3;
                    return View(bilgi3);
                case 4:
                    var bilgi4 = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).Include(i => i.kullanici);
                    var bilgi4c = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).Include(i => i.kullanici).Count();
                    if (bilgi4c == 0)
                    {
                        bilgi4 = null;
                    }
                    var bilgiler4 = c.ForumSorus.Where(x => x.katego == Katego.Eğitim).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler4;
                    return View(bilgi4);

                default:
                    var bilgi5 = c.ForumSorus.Where(x => x.katego == Katego.Diğer).Include(i => i.kullanici);
                    var bilgi5c = c.ForumSorus.Where(x => x.katego == Katego.Diğer).Include(i => i.kullanici).Count();
                    if (bilgi5c == 0)
                    {
                        bilgi5 = null;
                    }
                    var bilgiler5 = c.ForumSorus.Where(x => x.katego == Katego.Diğer).OrderBy(r => Guid.NewGuid()).Take(5);
                    ViewData["gundem"] = bilgiler5;
                    return View(bilgi5);
            }
        }

        public IActionResult Gundem()
        {
            var bilgi = c.ForumSorus.Include(i => i.kullanici).OrderBy(o => o.eklemeTarih);
            var bilgiler = c.ForumSorus.Include(i => i.kullanici).OrderByDescending(o => o.eklemeTarih);
            ViewData["gundem"] = bilgiler;
            return PartialView(bilgi);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return RedirectToAction("Index");
        }
    }
}
