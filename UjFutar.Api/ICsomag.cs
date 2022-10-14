namespace UjFutar.Api;

//Ez az interfész szabadon bővíthető a követelmények figyelembevételével
public interface ICsomag
{
    public Adatok Adatok();
    public void SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok);
    //további műveletek pl.: Csomagot kézbesít, Másik címre átírányít, stb.
}