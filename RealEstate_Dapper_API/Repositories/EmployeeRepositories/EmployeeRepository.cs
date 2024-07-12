using Dapper;
using RealEstate_Dapper_API.DTOs.EmployeeDTOs;
using RealEstate_Dapper_API.Models.DapperContext;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }

        public async void CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            string query = "insert into Employee (Name, Title, Mail, PhoneNumber, ImageURL, Status) values (@Name, @Title, @Mail, @PhoneNumber, @ImageURL, @Status)";
            var parameters = new DynamicParameters();
            parameters.Add("@Name", createEmployeeDTO.Name);
            parameters.Add("@Title", createEmployeeDTO.Title);
            parameters.Add("@Mail", createEmployeeDTO.Mail);
            parameters.Add("@PhoneNumber", createEmployeeDTO.PhoneNumber);
            parameters.Add("@ImageURL", createEmployeeDTO.ImageURL);
            parameters.Add("@Status", true);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {
            string query = "delete from Employee where EmployeeID=@EmployeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", id);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDTO>> GetAllEmployeesAsync()
        {
            string query = "select * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDTO>(query);
                return values.ToList();
            }
        }

        public async Task<GetEmployeeByIdDTO> GetEmployee(int id)
        {
            string query = "select * from Employee where EmployeeID=@EmployeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", id);

            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetEmployeeByIdDTO>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO)
        {
            string query = "update Employee set Name=@Name, Title=@Title, Mail=@Mail, PhoneNumber=@PhoneNumber, ImageURL=@ImageURL, Status=@Status where EmployeeID=@EmployeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", updateEmployeeDTO.EmployeeId);
            parameters.Add("@Name", updateEmployeeDTO.Name);
            parameters.Add("@Title", updateEmployeeDTO.Title);
            parameters.Add("@Mail", updateEmployeeDTO.Mail);
            parameters.Add("@PhoneNumber", updateEmployeeDTO.PhoneNumber);
            parameters.Add("@ImageURL", updateEmployeeDTO.ImageURL);
            parameters.Add("@Status", updateEmployeeDTO.Status);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
