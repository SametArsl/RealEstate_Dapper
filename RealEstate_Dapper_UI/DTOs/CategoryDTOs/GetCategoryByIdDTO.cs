﻿namespace RealEstate_Dapper_UI.DTOs.CategoryDTOs
{
    public class GetCategoryByIdDTO
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
