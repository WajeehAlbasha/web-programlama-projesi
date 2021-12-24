using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SözlükForum.Models;

namespace SözlükForum.Controllers
{
    public class KullaniciController : Controller
    {
        Contex c = new Contex();

        public IActionResult Index(int id)
        {
            ViewData vd = new ViewData();
            vd.kullanicis = c.Kullanicis.Where(x => x.id == id);
            vd.forumSoruss = c.ForumSorus.Where(x => x.kullanici.id == id);
            vd.yorums = c.Yorums.Where(x => x.kullanici.id == id);
            return View(vd);
        }
        public IActionResult YeniKullanici()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKullanici(Kullanici k)
        {
            k.admin = false;
            if (ModelState.IsValid)
            {
                var kont = c.Kullanicis.FirstOrDefault(x => x.kullanıcıAd == k.kullanıcıAd);
                var kont2 = c.Kullanicis.FirstOrDefault(x => x.email == k.email);
                if((kont is null)&&(kont2 is null))
                {
                    c.Kullanicis.Add(k);
                    c.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                if(!(kont is null))
                {
                    ViewBag.mesaj = "Kullanıcı Adı kullanılıyor";
                }
                else
                {
                    ViewBag.mesaj = "Email kullanılıyor";
                }
                return View("YeniKullanici");
            }
            else
            {
                return RedirectToAction("YeniKullanici");
            }
        }
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(Kullanici k)
        {
            var bilgi = c.Kullanicis.FirstOrDefault(x => x.kullanıcıAd == k.kullanıcıAd && x.sifre == k.sifre);
            if (bilgi != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, k.kullanıcıAd)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                var admin = c.Kullanicis.Where(x => x.kullanıcıAd == k.kullanıcıAd).FirstOrDefault(x => x.admin == true);
                if (!(admin is null))
                {
                    return RedirectToAction("Index", "Panel");
                }
                return RedirectToAction("index", "Home");
            }
            ViewBag.mesaj = "Giriş Yapılamadı.";
            return View("GirisYap");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
