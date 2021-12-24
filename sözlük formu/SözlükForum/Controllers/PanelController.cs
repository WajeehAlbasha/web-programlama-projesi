using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SözlükForum.Models;

namespace SözlükForum.Controllers
{
    public class PanelController : Controller
    {
        Contex c = new Contex();
        [Authorize]
        public IActionResult Index()
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici ).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                ViewData vd = new ViewData();
                vd.kullanicis = c.Kullanicis.ToList();

                return View(vd);
            }
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult ForumIndex()
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                ViewData vd = new ViewData();
                vd.forumSoruss = c.ForumSorus.Include(x => x.kullanici).ToList();

                return View(vd);
            }
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult YorumIndex()
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                ViewData vd = new ViewData();
                vd.yorums = c.Yorums.Include(x => x.forumsoru).Include(x => x.kullanici).ToList();

                return View(vd);
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult KullaniciSil(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var sil = c.Kullanicis.FirstOrDefault(x => x.id == id);
                c.Kullanicis.Remove(sil);
                c.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public async Task<IActionResult> KullaniciUpdate(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var kullan = await c.Kullanicis.FindAsync(id);
                if (kullan == null)
                {
                    return NotFound();
                }
                return View(kullan);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> KullaniciUpdate(int id, [Bind("kullanıcıAd, sifre, email")] Kullanici k)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                if (!(k.kullanıcıAd is null || k.sifre is null || k.email is null))
                {
                    k.id = id;
                    c.Update(k);
                    await c.SaveChangesAsync();
                    return RedirectToAction("ForumIndex");
                }
                return RedirectToAction("KullaniciUpdate", id);
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> SoruUpdate(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var kullan = await c.ForumSorus.FindAsync(id);
                if (kullan == null)
                {
                    return NotFound();
                }
                return View(kullan);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SoruUpdate(int id, [Bind("soru, icerik, katego, eklemeTarih")] ForumSoru f)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                if (!(f.soru is null))
                {
                    f.Id = id;
                    c.Update(f);
                    await c.SaveChangesAsync();
                    return RedirectToAction("ForumIndex");
                }
                return RedirectToAction("KullaniciUpdate", id);
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public async Task<IActionResult> YorumUpdate(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var kullan = await c.Yorums.FindAsync(id);
                if (kullan == null)
                {
                    return NotFound();
                }
                return View(kullan);
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> YorumUpdate(int id, [Bind("Icerik, Zaman")] Yorum y)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                if (!(y.Icerik is null))
                {
                    y.Id = id;
                    c.Update(y);
                    await c.SaveChangesAsync();
                    return RedirectToAction("ForumIndex");
                }
                return RedirectToAction("KullaniciUpdate", id);
            }
            return RedirectToAction("Index", "Home");
        }


        [Authorize]
        public IActionResult SoruSil(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var sil = c.ForumSorus.FirstOrDefault(x => x.Id == id);
                c.ForumSorus.Remove(sil);
                c.SaveChanges();
                return RedirectToAction("ForumIndex");
            }
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult YorumSil(int id)
        {
            var kullanici = User.Identity.Name;
            var deger = c.Kullanicis.Where(x => x.kullanıcıAd == kullanici).Where(x => x.admin == true).Count();
            if (deger != 0)
            {
                var sil = c.Yorums.FirstOrDefault(x => x.Id == id);
                c.Yorums.Remove(sil);
                c.SaveChanges();
                return RedirectToAction("YorumIndex");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
