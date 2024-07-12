using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.WhoWeAreDetailRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailsController : Controller
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreRepository;

        public WhoWeAreDetailsController(IWhoWeAreDetailRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> WhoWeAreDetailList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreDetailAsync();

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            _whoWeAreRepository.CreateWhoWeAreDetailAsync(createWhoWeAreDetailDTO);

            return Ok("New WhoWeAreDetail added succesfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            _whoWeAreRepository.DeleteWhoWeAreDetailAsync(id);

            return Ok("WhoWeAreDetail deleted succesfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            _whoWeAreRepository.UpdateWhoWeAreDetailAsync(updateWhoWeAreDetailDTO);

            return Ok("WhoWeAreDetail updated succesfully!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWhoWeAreDetailById(int id)
        {
            var value = await _whoWeAreRepository.GetWhoWeAreDetailById(id);

            return Ok(value);
        }
    }
}
