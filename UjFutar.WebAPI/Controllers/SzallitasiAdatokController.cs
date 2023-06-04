using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UjFutar.Api.Models;
using UjFutar.Repository.Interface;
using UjFutar.WebAPI.DTO;

namespace UjFutar.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SzallitasiAdatokController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISzallitasiAdatokRepository _repository;

        public SzallitasiAdatokController(
            ISzallitasiAdatokRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSzallitasiAdatokList()
        {
            try
            {
                var result = _repository.GetSzallitasiAdatokList().Result;
                return Ok(_mapper.Map<List<SzallitasiAdatokDTO>>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSzallitasiAdatok(SzallitasiAdatokDTO szallitasiAdatok)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.AddSzallitasiAdatok(_mapper.Map<SzallitasiAdatok>(szallitasiAdatok));
                }
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Something went wrong");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetSzallitasiAdatok(int id)
        {
            try
            {
                var result = _repository.GetSzallitasiAdatok(id).Result;
                return Ok(_mapper.Map<SzallitasiAdatokDTO>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
