using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.Repositories.BottomGridRepositories;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridsAsync();

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDTO);

            return Ok("New Bottom Grid added succesfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBottomGrid(int id)
        {
            _bottomGridRepository.DeleteBottomGrid(id);

            return Ok("Bottom Grid deleted succesfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDTO);

            return Ok("Bottom Grid updated succesfully!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGridById(int id)
        {
            var value = await _bottomGridRepository.GetBottomGridById(id);

            return Ok(value);
        }
    }
}
