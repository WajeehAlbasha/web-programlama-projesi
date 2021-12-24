using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace SözlükForum.Controllers
{
    public class ForumSoruController : Controller
    {
        //private readonly UserManager<Kullanici> _userManager;
        //public ForumSoruController(UserManager<Kullanici> userManager)
        //{
        //    _userManager = userManager;
        //}

        Contex c = new Contex();
        public async Task<IActionResult> Detail(ForumSoru f)
        {
            //ViewBag.a = _userManager.GetUserId(HttpContext.User);
            ViewData vd = new ViewData();
            vd.forumSoruss = c.ForumSorus.Where(s => s.Id == f.Id).Include(i => i.kullanici);
            vd.yorums = c.Yorums.Where(s => s.forumsoru.Id == f.Id).Include(i => i.kullanici);
            var bilgi = c.ForumSorus.Where(s => s.Id == f.Id).Include(i => i.kullanici).FirstOrDefault();
            //return View(await bilgi.ToListAsync());
            return View(vd);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Detail(int id, ViewData y)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    if (y.yorumss.Icerik != "")
                    {
                        //string bil = HttpContext.Session.GetString("isUserLogin");
                        y.yorumss.kullanici = c.Kullanicis.Where(x => x.kullanıcıAd == User.Identity.Name).FirstOrDefault();
                        y.yorumss.forumsoru = c.ForumSorus.Where(x => x.Id == id).FirstOrDefault();
                        c.Yorums.Add(y.yorumss);
                        c.SaveChanges();
                        return RedirectToAction("Detail", "ForumSoru", id);
                    }
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.mesaj = "Giriş Yapılamadı.";
                    return View("GirisYap");
                }
            }
            catch
            {
                return RedirectToAction("Index","Home");
            }
        }
        [Authorize]
        public IActionResult Kayit()
        {

            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Kayit(ForumSoru f)
        {
            if (ModelState.IsValid)
            {
                f.kullanici = c.Kullanicis.Where(x => x.kullanıcıAd== User.Identity.Name).FirstOrDefault();
                c.ForumSorus.Add(f);
                c.SaveChanges();
                return RedirectToAction("Detail","ForumSoru", f);
            }
            else
            {
                return RedirectToAction("Kayit");
            }
        }
    }

}
