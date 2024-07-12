using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDTO>> GetAllCategoriesAsync();
        void CreateCategory(CreateCategoryDTO categoryDTO);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDTO categoryDTO);
        Task<GetCategoryByIdDTO> GetCategoryById(int id);
    }
}
