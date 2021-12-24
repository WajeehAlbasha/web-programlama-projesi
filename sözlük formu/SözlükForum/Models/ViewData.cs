using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SözlükForum.Models
{
    public class ViewData
    {
        public IEnumerable<ForumSoru> forumSoruss{get; set;}
        public ForumSoru forumSoru{get; set;}
        public Yorum yorumss{get; set;}
        public IEnumerable<Yorum> yorums{get; set;}
        public Kullanici kullanici { get; set; }
        public IEnumerable<Kullanici> kullanicis { get; set; }
    }
}
