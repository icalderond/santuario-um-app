using SantuarioUM.Models;

namespace SantuarioUM.Utilities.Interfaces;

public interface ISantuarioService
{
    /// <summary>
    /// Get santuario data
    /// </summary>
    /// <returns></returns>
    Task<SantuarioData> GetSantuarioData();
}