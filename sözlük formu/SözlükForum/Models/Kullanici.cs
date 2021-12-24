using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class Kullanici
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        [MaxLength(40, ErrorMessage = "Maksimum 40 Karakter Olmalı...")]
        public string kullanıcıAd { get; set; }

        [DataType(DataType.Password)]
        [MaxLength(10, ErrorMessage ="Maksimum 10 Karakter Olmalı...")]
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        public string sifre { get; set; }
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public bool admin { get; set; }

        public List<ForumSoru> forumSorus { get; set; }
        public List<Yorum> yorums { get; set; }
        public List<SoruBegen> soruBegens { get; set; }

    }

}
