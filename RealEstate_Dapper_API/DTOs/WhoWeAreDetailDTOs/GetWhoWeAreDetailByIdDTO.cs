﻿namespace RealEstate_Dapper_API.DTOs.WhoWeAreDetailDTOs
{
    public class GetWhoWeAreDetailByIdDTO
    {
        public int WhoWeAreDetailID { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
    }
}
