using PrintersFrontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace PrintersFrontend.Services
{
    public class AuthService
    {
        private readonly LocalStorageService _localStorageService;
        private HttpClient _http;

        public AuthService(LocalStorageService localStorageService, HttpClient Http)
        {
            _localStorageService = localStorageService;
            _http = Http;
        }

        public async Task<bool> AuthenticateAsync(AUser user)
        {
            var auth = new login_token();
            var res = await _http.PostAsJsonAsync("https://localhost:44337/api/users/token", user);
            auth = await res.Content.ReadFromJsonAsync<login_token>();

            if (res.IsSuccessStatusCode && auth.name != null)
            {
                await _localStorageService.SetAsync($"printers_login_name", auth.name);
                await _localStorageService.SetAsync($"printers_login_token", auth.token);
                return true;
            }
            else
            {
               return false;
            }
        }

        public async Task<string> GetTokenAsync()
        {
            return await _localStorageService.GetAsync($"printers_login_token");
        }

        public async Task<string> GetNameAsync()
        {
            return await _localStorageService.GetAsync($"printers_login_name");
        }

        public async Task LogOut()
        {
            await _localStorageService.RemoveAsync($"printers_login_token");
            await _localStorageService.RemoveAsync($"printers_login_name");
        }

        public async Task<string> GetRoleAsync()
        {
            string login = await _localStorageService.GetAsync($"printers_login_name");

            if (string.IsNullOrEmpty(login))
            {
                return "Guest";
            }

            var res = await _http.GetAsync($"https://localhost:44337/api/users/role/{login}");
            var role = await res.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(role))
            {
                return "Guest";
            }
            else
            {
                return role;
            }
        }
    }
}
