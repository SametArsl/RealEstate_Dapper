using RealEstate_Dapper_API.DTOs.ProductDTOs;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDTO>> GetAllProductsAsync();
        Task<List<ResultProductWithCategoryDTO>> GetAllProductsWithCategoriesAsync();
    }
}
