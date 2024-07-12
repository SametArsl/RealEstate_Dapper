using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDTO>> GetAllBottomGridsAsync();
        void CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO);
        void DeleteBottomGrid(int id);
        void UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO);
        Task<GetBottomGridByIdDTO> GetBottomGridById(int id);
    }
}
