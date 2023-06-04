using UjFutar.Api.DTO;

namespace UjFutar.Api.Interface;

//Ez az interfész szabadon bővíthető a követelmények figyelembevételével
public interface ICsomag
{
    public CsomagAdatok Adatok();
    //public void SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok);
    //public void Felvesz(CsomagAdatok csomagAdatok);
    //public void AtveteliIgenytRogzit(CsomagAdatok csomagAdatok);
    //public void KozpontbaErkezik(CsomagAdatok csomagAdatok);
    //public void FelvetelreElokeszit(CsomagAdatok csomagAdatok);
    //public void KezbesitonekAtad(CsomagAdatok csomagAdatok);
    //public void AtiranyitMasikCimre(CsomagAdatok csomagAdatok);
    //public void Atvesz(CsomagAdatok csomagAdatok);
    //public void Kezbesit(CsomagAdatok csomagAdatok);
    //további műveletek pl.: Csomagot kézbesít, Másik címre átírányít, stb.
}