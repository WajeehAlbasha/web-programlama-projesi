using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class SoruBegen
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Boş Bırakamazsınız...")]
        public string kulsor { get; set; }

        public Kullanici kullanici { get; set; }

        public ForumSoru forumSoru { get; set; }
    }
}
