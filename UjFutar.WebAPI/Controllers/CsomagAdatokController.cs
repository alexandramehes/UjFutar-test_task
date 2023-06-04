using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UjFutar.Api.Models;
using UjFutar.Repository.Interface;
using UjFutar.WebAPI.DTO;

namespace UjFutar.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CsomagAdatokController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICsomagAdatokRepository _repository;

        public CsomagAdatokController(
            ICsomagAdatokRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetCsomagAdatokList()
        {
            try
            {
                var result = _repository.GetCsomagAdatokList().Result;
                return Ok(_mapper.Map<List<CsomagAdatokDTO>>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCsomagAdatok(CsomagAdatokDTO csomagAdatok)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.AddCsomagAdatok(_mapper.Map<CsomagAdatok>(csomagAdatok));
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
        public IActionResult GetCsomagAdatok(int id)
        {
            try
            {
                var result = _repository.GetCsomagAdatok(id).Result;
                return Ok(_mapper.Map<CsomagAdatokDTO>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}