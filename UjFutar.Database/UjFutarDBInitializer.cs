using Microsoft.EntityFrameworkCore;
using UjFutar.Api.DTO;

namespace UjFutar.Database
{
    public static class UjFutarDBInitializer
    {
        //3 szemely es 3 ures allapotban levo csomag , hogy kesob tetszes szerint allithato legyen az allapotuk
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Szemely>().HasData(new Szemely(1, "Teszt Elek1", "Teszt utca 1", "teszt1@teszt.hu"));
            builder.Entity<Szemely>().HasData(new Szemely(2, "Teszt Elek2", "Teszt utca 2", "teszt2@teszt.hu"));
            builder.Entity<Szemely>().HasData(new Szemely(3, "Teszt Elek3", "Teszt utca 3", "teszt3@teszt.hu"));

            builder.Entity<SzallitasiAdatok>().HasData(new SzallitasiAdatok(001, 1, 2));
            builder.Entity<SzallitasiAdatok>().HasData(new SzallitasiAdatok(002, 3, 1));
            builder.Entity<SzallitasiAdatok>().HasData(new SzallitasiAdatok(003, 2, 3));

            builder.Entity<CsomagAdatok>().HasData(new CsomagAdatok(001, CsomagAdatok.AllapotEnum.Ures, "Teszt utca 1"));
            builder.Entity<CsomagAdatok>().HasData(new CsomagAdatok(002, CsomagAdatok.AllapotEnum.Ures, "Teszt utca 2"));
            builder.Entity<CsomagAdatok>().HasData(new CsomagAdatok(003, CsomagAdatok.AllapotEnum.Ures, "Teszt utca 3"));
        }
    }
}