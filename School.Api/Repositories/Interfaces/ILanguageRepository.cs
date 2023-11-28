using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguagesAsync();
        Task<LanguageModel> GetLanguageByIdAsync(int languageId);
        Task<LanguageModel> AddLanguageAsync(LanguageModel language);
        Task<LanguageModel> UpdateLanguageAsync(int languageId, LanguageModel language);
        Task<bool> DeleteLanguageAsync(int languageId);
    }
}
