using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UjFutar.Api.Models;
using UjFutar.Repository.Interface;
using UjFutar.WebAPI.DTO;

namespace UjFutar.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SzemelyController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ISzemelyRepository _repository;

        public SzemelyController(
            ISzemelyRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetSzemelyList()
        {
            try
            {
                var result = _repository.GetSzemelyList().Result;
                return Ok(_mapper.Map<List<SzemelyDTO>>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateSzemely(SzemelyDTO szemely)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.AddSzemely(_mapper.Map<Szemely>(szemely));
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
        public IActionResult GetSzemely(int id)
        {
            try
            {
                var result = _repository.GetSzemely(id).Result;
                return Ok(_mapper.Map<SzemelyDTO>(result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}