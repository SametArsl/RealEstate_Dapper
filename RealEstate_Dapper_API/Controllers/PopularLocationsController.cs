using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_API.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;

        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopularLocationsList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationsAsync();

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDTO)
        {
            _popularLocationRepository.CreatePopularLocation(createPopularLocationDTO);

            return Ok("New Popular Location added succesfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocation(id);

            return Ok("Popular Location deleted succesfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            _popularLocationRepository.UpdatePopularLocation(updatePopularLocationDTO);

            return Ok("Popular Location updated succesfully!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocationById(int id)
        {
            var value = await _popularLocationRepository.GetPopularLocationById(id);

            return Ok(value);
        }
    }
}
