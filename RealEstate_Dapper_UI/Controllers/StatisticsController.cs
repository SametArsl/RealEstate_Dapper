using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            #region ActiveCategoryCount
            var activeCategoryCountClient = _httpClientFactory.CreateClient();
            var activeCategoryCountResponseMessage = await activeCategoryCountClient.GetAsync("https://localhost:44380/api/Statistics/ActiveCategoryCount");
            var activeCategoryCountJsonData = await activeCategoryCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.activeCategoryCount = activeCategoryCountJsonData;
            #endregion

            #region ActiveEmployeeCount
            var activeEmployeeCountClient = _httpClientFactory.CreateClient();
            var activeEmployeeCountResponseMessage = await activeEmployeeCountClient.GetAsync("https://localhost:44380/api/Statistics/ActiveEmployeeCount");
            var activeEmployeeCountJsonData = await activeEmployeeCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.activeEmployeeCount = activeEmployeeCountJsonData;
            #endregion

            #region ApartmentCount
            var apartmentCountClient = _httpClientFactory.CreateClient();
            var apartmentCountResponseMessage = await apartmentCountClient.GetAsync("https://localhost:44380/api/Statistics/ApartmentCount");
            var apartmentCountJsonData = await apartmentCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.apartmentCount = apartmentCountJsonData;
            #endregion

            #region AveragePriceOfProductsForRent
            var averagePriceOfProductsForRentClient = _httpClientFactory.CreateClient();
            var averagePriceOfProductsForRentResponseMessage = await averagePriceOfProductsForRentClient.GetAsync("https://localhost:44380/api/Statistics/AveragePriceOfProductsForRent");
            var averagePriceOfProductsForRentJsonData = await averagePriceOfProductsForRentResponseMessage.Content.ReadAsStringAsync();
            ViewBag.averagePriceOfProductsForRent = averagePriceOfProductsForRentJsonData;
            #endregion

            #region AveragePriceOfProductsForSale
            var averagePriceOfProductsForSaleClient = _httpClientFactory.CreateClient();
            var averagePriceOfProductsForSaleResponseMessage = await averagePriceOfProductsForSaleClient.GetAsync("https://localhost:44380/api/Statistics/AveragePriceOfProductsForSale");
            var averagePriceOfProductsForSaleJsonData = await averagePriceOfProductsForSaleResponseMessage.Content.ReadAsStringAsync();
            ViewBag.averagePriceOfProductsForSale = averagePriceOfProductsForSaleJsonData;
            #endregion

            #region AverageRoomCount
            var averageRoomCountClient = _httpClientFactory.CreateClient();
            var averageRoomCountResponseMessage = await averageRoomCountClient.GetAsync("https://localhost:44380/api/Statistics/AverageRoomCount");
            var averageRoomCountJsonData = await averageRoomCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.averageRoomCount = averageRoomCountJsonData;
            #endregion

            #region CategoryCount
            var categoryCountClient = _httpClientFactory.CreateClient();
            var categoryCountResponseMessage = await categoryCountClient.GetAsync("https://localhost:44380/api/Statistics/CategoryCount");
            var categoryCountJsonData = await categoryCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.categoryCount = categoryCountJsonData;
            #endregion

            #region CategoryNameByMaxProductCount
            var categoryNameByMaxProductCountClient = _httpClientFactory.CreateClient();
            var categoryNameByMaxProductCountResponseMessage = await categoryNameByMaxProductCountClient.GetAsync("https://localhost:44380/api/Statistics/CategoryNameByMaxProductCount");
            var categoryNameByMaxProductCountJsonData = await categoryNameByMaxProductCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = categoryNameByMaxProductCountJsonData;
            #endregion

            #region CityNameWithTheMostProducts
            var cityNameWithTheMostProductsClient = _httpClientFactory.CreateClient();
            var cityNameWithTheMostProductsResponseMessage = await cityNameWithTheMostProductsClient.GetAsync("https://localhost:44380/api/Statistics/CityNameWithTheMostProducts");
            var cityNameWithTheMostProductsJsonData = await cityNameWithTheMostProductsResponseMessage.Content.ReadAsStringAsync();
            ViewBag.cityNameWithTheMostProducts = cityNameWithTheMostProductsJsonData;
            #endregion

            #region CitiesCount
            var citiesCountclient = _httpClientFactory.CreateClient();
            var citiesCountResponseMessage = await citiesCountclient.GetAsync("https://localhost:44380/api/Statistics/CitiesCount");
            var citiesCountJsonData = await citiesCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.CitiesCount = citiesCountJsonData;
            #endregion

            #region EmployeeNameByMaxProductCount
            var employeeNameByMaxProductCountClient = _httpClientFactory.CreateClient();
            var employeeNameByMaxProductCountResponseMessage = await employeeNameByMaxProductCountClient.GetAsync("https://localhost:44380/api/Statistics/EmployeeNameByMaxProductCount");
            var employeeNameByMaxProductCountJsonData = await employeeNameByMaxProductCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.employeeNameByMaxProductCount = employeeNameByMaxProductCountJsonData;
            #endregion

            #region LastProductPrice
            var lastProductPriceClient = _httpClientFactory.CreateClient();
            var lastProductPriceResponseMessage = await lastProductPriceClient.GetAsync("https://localhost:44380/api/Statistics/LastProductPrice");
            var lastProductPriceJsonData = await lastProductPriceResponseMessage.Content.ReadAsStringAsync();
            ViewBag.lastProductPrice = lastProductPriceJsonData;
            #endregion

            #region NewestBuildingYear
            var newestBuildingYearClient = _httpClientFactory.CreateClient();
            var newestBuildingYearResponseMessage = await newestBuildingYearClient.GetAsync("https://localhost:44380/api/Statistics/NewestBuildingYear");
            var newestBuildingYearJsonData = await newestBuildingYearResponseMessage.Content.ReadAsStringAsync();
            ViewBag.newestBuildingYear = newestBuildingYearJsonData;
            #endregion

            #region OldestBuildingYear
            var oldestBuildingYearClient = _httpClientFactory.CreateClient();
            var oldestBuildingYearResponseMessage = await oldestBuildingYearClient.GetAsync("https://localhost:44380/api/Statistics/OldestBuildingYear");
            var oldestBuildingYearJsonData = await oldestBuildingYearResponseMessage.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = oldestBuildingYearJsonData;
            #endregion

            #region PassiveCategoryCount
            var passiveCategoryCountClient = _httpClientFactory.CreateClient();
            var passiveCategoryCountResponseMessage = await passiveCategoryCountClient.GetAsync("https://localhost:44380/api/Statistics/PassiveCategoryCount");
            var passiveCategoryCountJsonData = await passiveCategoryCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.passiveCategoryCount = passiveCategoryCountJsonData;
            #endregion

            #region ProductCount
            var productCountClient = _httpClientFactory.CreateClient();
            var productCountResponseMessage = await productCountClient.GetAsync("https://localhost:44380/api/Statistics/ProductCount");
            var productCountJsonData = await productCountResponseMessage.Content.ReadAsStringAsync();
            ViewBag.productCount = productCountJsonData;
            #endregion

            return View();
        }
    }
}
