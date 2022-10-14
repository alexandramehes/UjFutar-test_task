using NUnit.Framework;
using UjFutar.EsemenyTar.Api;

namespace UjFutar.MemoryEsemenyTar.Unit;

//Nem módosítható
[TestFixture]
public class EsmenyekBemutatasa
{
    [Test]
    public void Oklevelek()
    {
        IEsemenyTar esemenyTar = new MemoryEsemenyTar();

        var oklevelEsemeny1 = new OklevelKiallitva()
        {
            Azonosito = "00001",
            Idopont = new DateTime(2020, 11, 13),
            Nev = "Lupán Zsana",
            Telepules = "Zalaegerszeg",
        };
        var oklevelEsemeny2 = new OklevelKiallitva()
        {
            Azonosito = "00002",
            Idopont = new DateTime(2021, 3, 11),
            Nev = "Antonek Orasek Ariel",
            Telepules = "Budapest",
        };
        var oklevelEsemeny3 = new OklevelKiallitva()
        {
            Azonosito = "00003",
            Idopont = new DateTime(2021, 3, 11),
            Nev = "Czinboray Brenda",
            Telepules = "Mohács",
        };
        var oklevelEsemeny4 = new OklevelVisszavonva() { Azonosito = "00001" };

        esemenyTar.Ment(new List<Esemeny>() { oklevelEsemeny1, oklevelEsemeny2, oklevelEsemeny3, oklevelEsemeny4 });

        var osszesEsemeny = esemenyTar.OsszesEsemeny();
        var elsoOklevelEsemenyei = esemenyTar.Esemenyek("00001");
        var masodikOklevelEsemenyei = esemenyTar.Esemenyek("00002");
    }
}