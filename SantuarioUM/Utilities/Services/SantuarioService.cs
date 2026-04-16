using System.Text.Json;
using SantuarioUM.Models;
using SantuarioUM.Utilities.Constants;
using SantuarioUM.Utilities.Interfaces;

namespace SantuarioUM.Utilities.Services;

public class SantuarioService : ISantuarioService
{
    /// <summary>
    /// Get santuario data
    /// </summary>
    /// <returns></returns>
    public async Task<SantuarioData> GetSantuarioData()
    {
        return await GetAllDataAsync();
    }

    /// <summary>
    /// Get all data async
    /// </summary>
    /// <returns></returns>
    private async Task<SantuarioData> GetAllDataAsync()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync(SettingConstants.SantuarioFile);
            using var reader = new StreamReader(stream);

            var dataJson = reader.ReadToEndAsync();
            var jsonString = dataJson.Result;

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<SantuarioData>(jsonString, options);
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}