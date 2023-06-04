using System;
using UjFutar.Api.DTO;
using UjFutar.Api.Interface;
using UjFutar.EsemenyTar.Api;

namespace UjFutar;

//Ezt az osztályt kell megírni.
//az adatok tarolasat vegzi

//rogzitjuk a csomaggal tortent eventeket es adatokat - domain event
//esemenytarbol kiolvashatjuk adott csomag osszes esemenyet, adatait - event stream
// eldonthejuk hogy adott muvelet elvegezheto e MOST a csomagon - pl 

public class Csomag : ICsomag
{
    public Csomag(IEsemenyTar esemenyTar, string azonosito)
    {
    }

    public void SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok)
    {
        throw new NotImplementedException();
    }

    public CsomagAdatok Adatok()
    {
        throw new NotImplementedException(); //TODO: adatok kiadása
    }
    //TODO: további műveletek, implementáció
}