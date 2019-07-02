using SLNStokTakipV1.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLNStokTakipV1.Model
{   
    // ST --> Stok Takip
    class STContext : DbContext
    {
        public STContext():base("STContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<STContext, Configuration>("STContext"));
        }

        public virtual DbSet<bgFirma> bgFirmalar { get; set; }          // dbset:tablo oluştur, ismi bgfirmalar
        public virtual DbSet<bgFirmaTipi>bgFirmaTipleri { get; set; }
        public virtual DbSet<bgKategori>bgKategoriler { get; set; }
        public virtual DbSet<bgKullanici> bgKullanicilar { get; set; }
        public virtual DbSet<bgKulTipi> bgKulTipleri { get; set; }
        public virtual DbSet<bgSira> bgSiralar { get; set; }
        public virtual DbSet<bgUrunGiris> bgUrunGirisleri { get; set; }
        public virtual DbSet<stStokDurum> stStokDurumlari { get; set; }
        public virtual DbSet<stUrunKayitAlt> stUrunKayitAlts { get; set; }
        public virtual DbSet<stUrunKayitUst> stUrunKayitUsts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)        //
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


    }
}
