using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class Yorum
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan boş bırakılamaz!")]
        [StringLength(300,ErrorMessage ="Max 300 olmalı")]
        public string Icerik { get; set; }
        public DateTime Zaman { get; set; }
        [Required]
        public Kullanici kullanici { get; set; }

        public ForumSoru forumsoru { get; set; }
        public Yorum()
        {
            this.Zaman = DateTime.UtcNow.ToLocalTime();
        }
    }
}
