
namespace RealEstate_Dapper_API.Repositories.StatisticRepositories
{
    public interface IStatisticsRepository
    {
        int CategoryCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
        int ProductCount();
        int ApartmentCount();
        string EmployeeNameByMaxProductCount();
        string CategoryNameByMaxProductCount();
        decimal AveragePriceOfProductsForSale();
        decimal AveragePriceOfProductsForRent();
        string CityNameWithTheMostProducts();
        int CitiesCount();
        decimal LastProductPrice();
        string NewestBuildingYear();
        string OldestBuildingYear();
        int AverageRoomCount();
        int ActiveEmployeeCount();

    }
}
