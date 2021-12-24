using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SözlükForum.Models;

namespace SözlükForum.Controllers
{

    public class YorumController : Controller
    {
        Contex c = new Contex();

        [HttpPost]
        [Authorize]
        public IActionResult Ekle(Yorum y)
        {
            if (y.Icerik != "")
            {
                //y.forumsoru = c.ForumSorus.Where(x => x.Id == id).FirstOrDefault();
                y.forumsoru = c.ForumSorus.Where(x => x.Id == 1).FirstOrDefault();
                c.Yorums.Add(y);
                c.SaveChanges();
                return RedirectToAction("Detail", "ForumSoru", 1);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
