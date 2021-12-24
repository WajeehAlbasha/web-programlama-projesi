using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;

namespace SözlükForum.Controllers
{
    public class SoruBegenController : Controller
    {
        Contex c = new Contex();
        [Authorize]
        public IActionResult BegenEkle(int id)
        {
            var bilgisoru = c.ForumSorus.Find(id);
            var bilgikullan = c.Kullanicis.Where(x => x.kullanıcıAd == User.Identity.Name).First();
            string bilgideger = bilgikullan.id.ToString() + bilgisoru.Id.ToString();
            SoruBegen begeni = new SoruBegen();
            begeni.forumSoru = bilgisoru;
            begeni.kullanici = bilgikullan;
            begeni.kulsor = bilgideger;
            c.SoruBegens.Add(begeni);
            c.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
