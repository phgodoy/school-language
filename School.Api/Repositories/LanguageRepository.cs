using School.Api.Models;
using School.Api.Repositories.Interfaces;
using System.Data.Entity;

namespace School.Api.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly TaskSystemDBContext _taskSystemDBContext;

        public LanguageRepository(TaskSystemDBContext taskSystemDBContext)
        {
            _taskSystemDBContext = taskSystemDBContext;
        }

        /// <inheritdoc />
        public async Task<LanguageModel> AddLanguageAsync(LanguageModel language)
        {
            await _taskSystemDBContext.Languages.AddAsync(language);
            await _taskSystemDBContext.SaveChangesAsync();

            return language;
        }

        /// <inheritdoc />
        public async Task<bool> DeleteLanguageAsync(int languageId)
        {
            LanguageModel languageModel = await GetLanguageByIdAsync(languageId);

            if (languageModel == null)
            {
                throw new Exception("IDIOMA NAO FOI ENCONTRADO");
            }
            _taskSystemDBContext.Languages.Remove(languageModel);
            await _taskSystemDBContext.SaveChangesAsync();
            return true;
        }

        /// <inheritdoc />
        public async Task<LanguageModel> GetLanguageByIdAsync(int languageId)
        {
            return await _taskSystemDBContext.Languages.FirstOrDefaultAsync(x => x.Id == languageId);
        }

        public async Task<List<LanguageModel>> GetLanguagesAsync()
        {
            return await _taskSystemDBContext.Languages.ToListAsync();
        }

        /// <inheritdoc />
        public async Task<LanguageModel> UpdateLanguageAsync(int languageId, LanguageModel languageData)
        {
            LanguageModel language = await GetLanguageByIdAsync(languageId);

            if (language == null)
            {
                throw new Exception("USUARIO NAO FOI ENCONTRADO");
            }

            _taskSystemDBContext.Entry(language).CurrentValues.SetValues(languageData);
            await _taskSystemDBContext.SaveChangesAsync();

            return language;
        }
    }
}
