using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreDetailRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetailAsync(CreateWhoWeAreDetailDTO createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetailAsync(int id);
        void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDto);
        Task<GetWhoWeAreDetailByIdDTO> GetWhoWeAreDetailById(int id);
    }
}
