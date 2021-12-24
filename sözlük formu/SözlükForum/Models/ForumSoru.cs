using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class ForumSoru
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız...")]
        [StringLength(100, ErrorMessage = "Max 100 olmalı")]
        public string soru { get; set; }
        public Kullanici kullanici { get; set; }
        public DateTime eklemeTarih { get; set; }
        [StringLength(500, ErrorMessage = "Max 500 olmalı")]
        public string icerik { get; set; }

        public List<Yorum> yorums { get; set; }

        public List<SoruBegen> soruBegens { get; set; }

        [Required(ErrorMessage ="Seçim Yapmalısınız...")]
        public Katego katego { get; set; } 

        public ForumSoru()
        {
            this.eklemeTarih = DateTime.UtcNow.ToLocalTime();

        }
    }
    public enum Katego
    {
        Diğer,
        Spor,
        Ekonomi,
        Sağlık,
        Eğitim,
    }
}
