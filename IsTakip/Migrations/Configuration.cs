namespace IsTakip.Migrations
{
    using IsTakip.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IsTakip.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(IsTakip.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Set<yakitTuru>().AddOrUpdate(

                new yakitTuru { yakitTuruID = 1, Tur = "Benzin" },
                new yakitTuru { yakitTuruID = 2, Tur = "Dizel" },
                new yakitTuru { yakitTuruID = 3, Tur = "Benzin/LPG" },
                new yakitTuru { yakitTuruID = 4, Tur = "Hybrid" },
                new yakitTuru { yakitTuruID = 5, Tur = "Elektrik" }
                );




            context.Set<Sabit>().AddOrUpdate(

                new Sabit
                {
                    adres = "Varsayılan Adres",
                    eposta = "isletmemail@.com",
                    iban1 = "tr12345",
                    iban2 = "tr67890",
                    isYeriAdi="İş Yeri Adı",
                    telefon="050511111111",
                    yetkiliAdiSoyadi="yetkili Adı Soyadı",
                    kdv = 20,
                }

                );


        }
    }
}
