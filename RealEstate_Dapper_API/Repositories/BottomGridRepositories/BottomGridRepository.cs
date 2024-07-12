using Dapper;
using RealEstate_Dapper_API.DTOs.BottomGridDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.BottomGridRepositories
{
    public class BottomGridRepository : IBottomGridRepository
    {
        private readonly Context _context;

        public BottomGridRepository(Context context)
        {
            _context = context;
        }
        public async void CreateBottomGrid(CreateBottomGridDTO createBottomGridDTO)
        {
            string query = "insert into BottomGrid (Icon, Title, Description) values (@icon, @title, @description)";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", createBottomGridDTO.Icon);
            parameters.Add("@title", createBottomGridDTO.Title);
            parameters.Add("@description", createBottomGridDTO.Description);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteBottomGrid(int id)
        {
            string query = "delete from BottomGrid where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultBottomGridDTO>> GetAllBottomGridsAsync()
        {
            string query = "select * from BottomGrid";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultBottomGridDTO>(query);
                return values.ToList();
            };
        }

        public async Task<GetBottomGridByIdDTO> GetBottomGridById(int id)
        {
            string query = "select * from BottomGrid where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@bottomGridId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetBottomGridByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateBottomGrid(UpdateBottomGridDTO updateBottomGridDTO)
        {
            string query = "update BottomGrid set Icon=@icon, Title=@title, Description=@description where BottomGridId=@bottomGridId";
            var parameters = new DynamicParameters();
            parameters.Add("@icon", updateBottomGridDTO.Icon);
            parameters.Add("@title", updateBottomGridDTO.Title);
            parameters.Add("@description", updateBottomGridDTO.Description);
            parameters.Add("@bottomGridId", updateBottomGridDTO.BottomGridId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
