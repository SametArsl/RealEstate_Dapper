﻿namespace RealEstate_Dapper_API.DTOs.ServiceDTOs
{
    public class GetServiceByIdDTO
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool ServiceStatus { get; set; }
    }
}
