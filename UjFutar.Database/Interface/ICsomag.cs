using Microsoft.AspNetCore.Mvc;
using UjFutar.Api.Models;

namespace UjFutar.Api.Interface;

//Ez az interfész szabadon bővíthető a követelmények figyelembevételével
public interface ICsomag
{
    Task<CsomagAdatok> GetCsomagAdatok(int id);
    public Task<SzallitasiAdatok> SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok);
    public Task<CsomagAdatok> CsomagotFelvesz(CsomagAdatok csomagAdatok);
    public Task<IActionResult> AtveteliIgenytRogzit(int csomagId);
    //public void KozpontbaErkezik(CsomagAdatok csomagAdatok);
    //public void FelvetelreElokeszit(CsomagAdatok csomagAdatok);
    //public void KezbesitonekAtad(CsomagAdatok csomagAdatok);
    //public void AtiranyitMasikCimre(CsomagAdatok csomagAdatok);
    //public void Atvesz(CsomagAdatok csomagAdatok);
    //public void Kezbesit(CsomagAdatok csomagAdatok);
}