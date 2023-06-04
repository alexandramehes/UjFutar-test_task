using AutoMapper;
using UjFutar.Api.Models;
using UjFutar.WebAPI.DTO;

namespace UjFutar.WebAPI.Mapper
{
    public class Profiles : Profile
    {
        public Profiles() {

            CreateMap<Szemely, SzemelyDTO>();
            CreateMap<SzemelyDTO, Szemely>();

            CreateMap<SzallitasiAdatok, SzallitasiAdatokDTO>();
            CreateMap<SzallitasiAdatokDTO, SzallitasiAdatok>();

            CreateMap<CsomagAdatok, CsomagAdatokDTO>();
            CreateMap<CsomagAdatokDTO, CsomagAdatok>();
        } 
    }
}
