using Dapper;
using RealEstate_Dapper_API.DTOs.ProductDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async void ChangeProductDealOfTheDayToFalse(int id)
        {
            string query = "Update Product Set DealOfTheDay=0 where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ChangeProductDealOfTheDayToTrue(int id)
        {
            string query = "Update Product Set DealOfTheDay=1 where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDTO>> GetAllProductsAsync()
        {
            string query = "select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDTO>(query);

                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDTO>> GetAllProductsWithCategoriesAsync()
        {
            string query = "select ProductID, Title, Price, City, District, CategoryName, CoverImage, Type, Address, DealOfTheDay from Product inner join Category on Product.ProductCategory = Category.CategoryID";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDTO>(query);

                return values.ToList();
            }
        }
    }
}
