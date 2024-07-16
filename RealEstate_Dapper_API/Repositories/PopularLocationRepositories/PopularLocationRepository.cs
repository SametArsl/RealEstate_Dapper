using Dapper;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.PopularLocationRepositories
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public async void CreatePopularLocation(CreatePopularLocationDTO createPopularLocationDTO)
        {
            string query = "insert into PopularLocation (CityName, ImageURL) values (@cityName, @imageURL)";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", createPopularLocationDTO.CityName);
            parameters.Add("@imageURL", createPopularLocationDTO.ImageURL);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeletePopularLocation(int id)
        {
            string query = "delete from PopularLocation where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultPopularLocationDTO>> GetAllPopularLocationsAsync()
        {
            string query = "select * from PopularLocation";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetPopularLocationByIdDTO> GetPopularLocationById(int id)
        {
            string query = "select * from PopularLocation where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@locationId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetPopularLocationByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdatePopularLocation(UpdatePopularLocationDTO updatePopularLocationDTO)
        {
            string query = "update PopularLocation set CityName=@cityName, ImageURL=@imageURL where LocationId=@locationId";
            var parameters = new DynamicParameters();
            parameters.Add("@cityName", updatePopularLocationDTO.CityName);
            parameters.Add("@imageURL", updatePopularLocationDTO.ImageURL);
            parameters.Add("@locationId", updatePopularLocationDTO.LocationId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
