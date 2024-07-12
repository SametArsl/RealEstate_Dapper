using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ProductDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.WhoWeAreDetailRepository
{
    public class WhoWeAreDetailRepository : IWhoWeAreDetailRepository
    {
        private readonly Context _context;

        public WhoWeAreDetailRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAreDetailAsync(CreateWhoWeAreDetailDTO createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title, SubTitle, Description1, Description2) values (@title, @subtitle, @description1, @description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", createWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetailAsync(int id)
        {
            string query = "delete from WhoWeAreDetail where WhoWeAreDetailId=@whowearedetailid";
            var parameters = new DynamicParameters();
            parameters.Add("@whowearedetailid", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWhoWeAreDetailDTO>> GetAllWhoWeAreDetailAsync()
        {
            string query = "select * from WhoWeAreDetail";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWhoWeAreDetailDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetWhoWeAreDetailByIdDTO> GetWhoWeAreDetailById(int id)
        {
            string query = "select * from WhoWeAreDetail where WhoWeAreDetailId=@whowearedetailid";
            var parameters = new DynamicParameters();
            parameters.Add("@whowearedetailid", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetWhoWeAreDetailByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateWhoWeAreDetailAsync(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDto)
        {
            string query = "update WhoWeAreDetail set Title=@title, SubTitle=@subtitle, Description1=@description1, Description2=@description2 where WhoWeAreDetailId=@whowearedetailid";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);
            parameters.Add("@whowearedetailid", updateWhoWeAreDetailDto.WhoWeAreDetailID);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
