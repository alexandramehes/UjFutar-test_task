using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UjFutar.Api.Interface;
using UjFutar.Api.Models;
using UjFutar.WebAPI.DTO;

namespace UjFutar.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CsomagController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICsomag _repository;

        public CsomagController(
            ICsomag repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        [HttpPost("/szallitasiAdatokatRogzit")]
        public async Task<IActionResult> SzallitasiAdatokatRogzit(SzallitasiAdatokDTO szallitasiAdatok)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.SzallitasiAdatokatRogzit(_mapper.Map<SzallitasiAdatok>(szallitasiAdatok));
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Something went wrong");
            }
        }

        [HttpPost("/csomagotFelvesz")]
        public async Task<IActionResult> CsomagotFelvesz(CsomagAdatokDTO csomagAdatok)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.CsomagotFelvesz(_mapper.Map<CsomagAdatok>(csomagAdatok));
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Something went wrong");
            }
        }
    }
}
