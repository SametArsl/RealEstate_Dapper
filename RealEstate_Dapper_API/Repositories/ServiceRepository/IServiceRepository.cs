using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDTO>> GetAllServicesAsync();
        void CreateService(CreateServiceDTO serviceDTO);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDTO serviceDTO);
        Task<GetServiceByIdDTO> GetServiceById(int id);
    }
}
