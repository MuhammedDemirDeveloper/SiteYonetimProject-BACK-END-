using Microsoft.EntityFrameworkCore;
using SiteYonetimModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteYonetimData_Access.Data
{
    public class SiteYonetimDbContext:DbContext
    {
        public SiteYonetimDbContext()
        {

        }
        public SiteYonetimDbContext(DbContextOptions<SiteYonetimDbContext>options):base(options)
        {

        }
        public DbSet<Firmalar> tb_Firmalar { get; set; }
        public DbSet<Siteler> tb_Siteler { get; set; }
        public DbSet<Bloklar> tb_Bloklar { get; set; }
        public DbSet<Personeller> tb_Personeller { get; set; }
        public DbSet<Daireler> tb_Daireler { get; set; }
        public DbSet<iller> tb_iller { get; set; }
        public DbSet<ilceler> tb_ilceler { get; set; }
        public DbSet<Ulkeler> tb_Ulkeler { get; set; }
        public DbSet<Kisiler> tb_Kisiler { get; set; }
        public DbSet<Cinsiyetler> tb_Cinsiyetler { get; set; }
        public DbSet<Uyruklar> tb_Uyruklar { get; set; }
        public DbSet<SozlesmeTarihleri> tb_SozlesmeTarihleri { get; set; }
        public DbSet<IsinmaTurleri> tb_IsinmaTurleri { get; set; }
        public DbSet<iletisimDilleri> tb_iletisimDilleri { get; set; }
        public DbSet<Meslekler> tb_Meslekler { get; set; }
        public DbSet<OgrenimDurumu> tb_OgrenimDurumu { get; set; }


    }
}
