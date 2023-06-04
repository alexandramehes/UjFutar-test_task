using UjFutar.EsemenyTar.Api;
using UjFutar.Database;
using UjFutar.Api.Interface;
using UjFutar.Api.Models;

namespace UjFutar;

//Ezt az osztályt kell megírni.
//az adatok tarolasat vegzi

//rogzitjuk a csomaggal tortent eventeket es adatokat - domain event
//esemenytarbol kiolvashatjuk adott csomag osszes esemenyet, adatait - event stream
// eldonthejuk hogy adott muvelet elvegezheto e MOST a csomagon - pl 

public class CsomagRepository : ICsomag
{
    public CsomagRepository(IEsemenyTar esemenyTar, string azonosito)
    {
    }

    public void SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok)
    {

    }

    public CsomagAdatok Adatok()
    {
        throw new NotImplementedException(); //TODO: adatok kiadása
    }
    //TODO: további műveletek, implementáció
}