using Dapper;
using RealEstate_Dapper_API.DTOs.CategoryDTOs;
using RealEstate_Dapper_API.DTOs.ServiceDTOs;
using RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public async void CreateService(CreateServiceDTO createServiceDTO)
        {
            string query = "insert into Service (ServiceName, ServiceStatus) values (@serviceName, @serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", createServiceDTO.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int id)
        {
            string query = "delete from Service where ServiceId=@serviceid";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceid", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultServiceDTO>> GetAllServicesAsync()
        {
            string query = "select * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetServiceByIdDTO> GetServiceById(int id)
        {
            string query = "select * from Service where ServiceId=@serviceid";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceid", id);

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetServiceByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDTO updateServiceDTO)
        {
            string query = "update Service set ServiceName=@serviceName, ServiceStatus=@serviceStatus where ServiceId=@serviceid";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", updateServiceDTO.ServiceName);
            parameters.Add("@serviceStatus", updateServiceDTO.ServiceStatus);
            parameters.Add("@serviceid", updateServiceDTO.ServiceId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
