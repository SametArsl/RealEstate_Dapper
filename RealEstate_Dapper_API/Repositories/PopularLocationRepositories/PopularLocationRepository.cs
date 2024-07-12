using Dapper;
using RealEstate_Dapper_API.DTOs.PopularLocationDTOs;
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

        public void CreatePopularLocation(CreatePopularLocationDTO popularLocationDTO)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocation(int id)
        {
            throw new NotImplementedException();
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

        public Task<GetPopularLocationByIdDTO> GetPopularLocationById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocation(UpdatePopularLocationDTO popularLocationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
