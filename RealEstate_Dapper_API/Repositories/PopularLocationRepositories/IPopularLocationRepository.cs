using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDTO>> GetAllPopularLocationsAsync();
        void CreatePopularLocation(CreatePopularLocationDTO popularLocationDTO);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(UpdatePopularLocationDTO popularLocationDTO);
        Task<GetPopularLocationByIdDTO> GetPopularLocationById(int id);
    }
}
