using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SözlükForum.Models;

namespace SözlükForum.Models
{
    public class Contex: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB; database=SözlükForumGelistirme; integrated security=true;");
        }

        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<ForumSoru> ForumSorus { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<SoruBegen> SoruBegens { get; set; }
    }
}
