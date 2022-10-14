using System;
using UjFutar.Api;
using UjFutar.EsemenyTar.Api;

namespace UjFutar;

//Ezt az osztályt kell megírni.
public class Csomag : ICsomag
{
    public Csomag(IEsemenyTar esemenyTar, string azonosito)
    {
    }

    public void SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok)
    {
        throw new NotImplementedException();
    }

    public Adatok Adatok()
    {
        throw new NotImplementedException(); //TODO: adatok kiadása
    }
    //TODO: további műveletek, implementáció
}