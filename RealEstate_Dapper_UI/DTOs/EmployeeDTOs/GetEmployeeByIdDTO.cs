﻿namespace RealEstate_Dapper_UI.DTOs.EmployeeDTOs
{
    public class GetEmployeeByIdDTO
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageURL { get; set; }
        public bool Status { get; set; }
    }
}
