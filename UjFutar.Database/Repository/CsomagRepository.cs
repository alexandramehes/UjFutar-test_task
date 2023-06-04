using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using UjFutar.Api.Interface;
using UjFutar.Api.Models;
using UjFutar.Database;
using UjFutar.EsemenyTar.Api;
using UjFutar.Repository.DomainEvent;

namespace UjFutar;

//Ezt az osztályt kell megírni.

public class CsomagRepository : ICsomag
{
    private readonly IEsemenyTar _esemenyTar;
    private readonly UjFutarContext context;
    public CsomagRepository(IEsemenyTar esemenyTar, UjFutarContext context)
    {
        _esemenyTar = esemenyTar;
        this.context = context;
    }

    public async Task<CsomagAdatok> GetCsomagAdatok(int id)
    {
        return await context.CsomagAdatok
            .FirstOrDefaultAsync(e => e.CsomagId == id);
    }

    public async Task<SzallitasiAdatok> SzallitasiAdatokatRogzit(SzallitasiAdatok szallitasiAdatok)
    {
        var result = await context.SzallitasiAdatok.AddAsync(szallitasiAdatok);
        await context.SaveChangesAsync();

        var szallitasiAdatokRogzitesEvent = new SzallitasiAdatokatRogzitDomainEvent { CsomagId = szallitasiAdatok.Id, Azonosito = "szallitasiAdatokFelveve" };
        _esemenyTar.Ment(new List<Esemeny> { szallitasiAdatokRogzitesEvent });
        return result.Entity;
    }

    public async Task<CsomagAdatok> CsomagotFelvesz(CsomagAdatok csomagAdatok)
    {
        csomagAdatok.SetAllapot("FelvetelreVar");
        var result = await context.CsomagAdatok.AddAsync(csomagAdatok);
        await context.SaveChangesAsync();

        var csomagRogzitesEvent = new CsomagotFelveszDomainEvent { CsomagId = csomagAdatok.CsomagId, Azonosito =  "csomagFelveve" };
        _esemenyTar.Ment(new List<Esemeny> { csomagRogzitesEvent });

        return result.Entity;
    }

    public async Task<IActionResult> AtveteliIgenytRogzit(int csomagId)
    {
        CsomagAdatok csomag = context.CsomagAdatok
                .FirstOrDefaultAsync(e => e.CsomagId == csomagId).Result;

        //if (csomag == null)
        //{
        //    return new NotFoundObjectResult(csomagId);
        //}

        csomag.SetAllapot("AtvetelreVar");
        context.CsomagAdatok.Update(csomag);
        await context.SaveChangesAsync();

        var csomagRogzitesEvent = new AtveteliIgenytRogzitDomainEvent { CsomagId = csomagId, Azonosito = "atveteliIgeyRogzitve" };
        _esemenyTar.Ment(new List<Esemeny> { csomagRogzitesEvent });

        return new ObjectResult(csomag)
        {
            StatusCode = (int)HttpStatusCode.OK
        };
    }
}