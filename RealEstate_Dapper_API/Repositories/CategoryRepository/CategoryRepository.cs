using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.Models.DapperContext;
using Dapper;

namespace RealEstate_Dapper_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDTO categoryDTO)
        {
            string query = "insert into Category (CategoryName, CategoryStatus) values (@categoryname, @categorystatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryname", categoryDTO.CategoryName);
            parameters.Add("@categorystatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            string query = "delete from Category where CategoryId=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoriesAsync()
        {
            string query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetCategoryByIdDTO> GetCategoryById(int id)
        {
            string query = "select * from Category where CategoryID=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);

            using (var connection = _context.CreateConnection()) 
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetCategoryByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            string query = "update Category set CategoryName=@categoryName, CategoryStatus=@categoryStatus where CategoryID=@categoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", updateCategoryDTO.CategoryName);
            parameters.Add("@categoryStatus", updateCategoryDTO.CategoryStatus);
            parameters.Add("@categoryID", updateCategoryDTO.CategoryID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
