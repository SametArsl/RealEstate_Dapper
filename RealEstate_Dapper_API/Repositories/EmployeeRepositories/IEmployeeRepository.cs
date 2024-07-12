using RealEstate_Dapper_API.DTOs.EmployeeDTOs;

namespace RealEstate_Dapper_API.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDTO>> GetAllEmployeesAsync();
        void CreateEmployee(CreateEmployeeDTO createEmployeeDTO);
        void DeleteEmployee(int id);
        void UpdateEmployee(UpdateEmployeeDTO updateEmployeeDTO);
        Task<GetEmployeeByIdDTO> GetEmployee(int id);
    }
}
