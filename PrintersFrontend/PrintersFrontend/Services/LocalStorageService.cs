using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace PrintersFrontend.Services
{
    public class LocalStorageService
    {
        private IJSRuntime _jsRuntime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public async Task SetAsync(string name, string value) =>
            await _jsRuntime.InvokeAsync<object>("LocalStorageSet", name, value);
        public async Task<string> GetAsync(string name) =>
            await _jsRuntime.InvokeAsync<string>("LocalStorageGet", name);
        public async Task RemoveAsync(string name) =>
            await _jsRuntime.InvokeAsync<object>("LocalStorageRemove", name);
    }
}
