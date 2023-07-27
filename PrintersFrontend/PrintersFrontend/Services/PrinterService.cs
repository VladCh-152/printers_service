using PrintersFrontend.Models;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace PrintersFrontend.Services
{
    public class PrinterService
    {
        private readonly AuthService _authService;
        private HttpClient _http;
        private string _token;
        private JsonSerializerOptions _jsonOptions;

        public PrinterService(AuthService authService, HttpClient Http)
        {
            _authService = authService;
            _http = Http;

            _jsonOptions = new JsonSerializerOptions();
            _jsonOptions.IgnoreNullValues = true;

        }

        public async Task<List<Printer>> getPrinters()
        {
            await LoadTokenAsync();
            var temp = await _http.GetAsync("https://localhost:44337/api/printers");
            if (temp.IsSuccessStatusCode)
            {
                return await temp.Content.ReadFromJsonAsync<List<Printer>>();
            }
            else
            {
                return null;
            }
        }

        public async Task<List<PrinterModel>> getModels()
        {
            await LoadTokenAsync();
            var temp = await _http.GetAsync("https://localhost:44337/api/printermodels");
            if (temp.IsSuccessStatusCode)
            {
                return await temp.Content.ReadFromJsonAsync<List<PrinterModel>>();
            }
            else
            {
                return null;
            }
        }

        public async Task<List<PrinterType>> getTypes()
        {
            await LoadTokenAsync();
            var temp = await _http.GetAsync("https://localhost:44337/api/printertypes");
            if (temp.IsSuccessStatusCode)
            {
                return await temp.Content.ReadFromJsonAsync<List<PrinterType>>();
            }
            else
            {
                return null;
            }
        }
        public async Task<List<Vendor>> getVendors()
        {
            await LoadTokenAsync();
            var temp = await _http.GetAsync("https://localhost:44337/api/vendors");
            if (temp.IsSuccessStatusCode)
            {
                return await temp.Content.ReadFromJsonAsync<List<Vendor>>();
            }
            else
            {
                return null;
            }
        }

        public async Task LoadTokenAsync()
        {
            if (string.IsNullOrEmpty(_token))
            {
                _token = await _authService.GetTokenAsync();
                Console.WriteLine($"token {_token}");
                if (!_http.DefaultRequestHeaders.Contains("Authorization"))
                {
                    _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {_token}");
                }
                Console.WriteLine($"Bearer success");
            }
        }
    }
}
