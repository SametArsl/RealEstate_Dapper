using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.Repositories.ServiceRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServicesController(IServiceRepository whoWeAreRepository)
        {
            _serviceRepository = whoWeAreRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServicesAsync();

            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDTO createServiceDTO)
        {
            _serviceRepository.CreateService(createServiceDTO);

            return Ok("New Service added succesfully!");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {
            _serviceRepository.DeleteService(id);

            return Ok("Service deleted succesfully!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            _serviceRepository.UpdateService(updateServiceDTO);

            return Ok("Service updated succesfully!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceById(int id)
        {
            var value = await _serviceRepository.GetServiceById(id);

            return Ok(value);
        }
    }
}
