﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_UI.DTOs.EmployeeDTOs;
using RealEstate_Dapper_UI.DTOs.WhoWeAreDTOs;
using System.Text;

namespace RealEstate_Dapper_UI.Controllers
{
    public class WhoWeAreController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WhoWeAreController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44380/api/WhoWeAreDetails");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDTO>>(jsonData);

                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateWhoWeAreDetail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAreDetail(CreateWhoWeAreDetailDTO createWhoWeAreDetailDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createWhoWeAreDetailDTO);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44380/api/WhoWeAreDetails", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> DeleteWhoWeAreDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44380/api/WhoWeAreDetails/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWhoWeAreDetail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44380/api/WhoWeAreDetails/{id}");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateWhoWeAreDetailDTO>(jsonData);

                return View(values);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDTO updateWhoWeAreDetailDTO)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateWhoWeAreDetailDTO);

            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44380/api/WhoWeAreDetails/", content);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
