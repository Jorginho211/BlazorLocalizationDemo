using System.Globalization;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorLocalizationDemo;

public static class WebAssemblyHostExtensions
{
    public static async Task SetDefaultCulture(this WebAssemblyHost host) {
        var localStorage = host.Services.GetRequiredService<ILocalStorageService>();
        var culture = await localStorage.GetItemAsync<string>("culture");

        CultureInfo cultureInfo;
        if (string.IsNullOrEmpty(culture)) {
            cultureInfo = new CultureInfo("es-ES");
            await localStorage.SetItemAsync("culture", "es-ES");
        }
        else {
            cultureInfo = new CultureInfo(culture);
        }

        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }
}