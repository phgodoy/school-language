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
        public async Task<LanguageModel> AddLanguageAsync(LanguageModel language)
        {
            await _taskSystemDBContext.Languages.AddAsync(language);
            await _taskSystemDBContext.SaveChangesAsync();

            return language;
        }

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

        public async Task<LanguageModel> GetLanguageByIdAsync(int languageId)
        {
            return await _taskSystemDBContext.Languages.FirstOrDefaultAsync(x => x.Id == languageId);
        }

        public async Task<List<LanguageModel>> GetLanguagesAsync()
        {
            return await _taskSystemDBContext.Languages.ToListAsync();
        }

        public  async Task<LanguageModel> UpdateLanguageAsync(int languageId, LanguageModel language)
        {
            LanguageModel languageModel = await GetLanguageByIdAsync(languageId);

            if (languageModel == null)
            {
                throw new Exception("uSUARIO NAO FOI ENCONTRADO");
            }

            languageModel.LanguageName = languageModel.LanguageName;
            
            _taskSystemDBContext.Languages.Update(languageModel);
            await _taskSystemDBContext.SaveChangesAsync();

            return languageModel;

        }
    }
}
