using System.Collections.Generic;
using System.Threading.Tasks;
using School.Api.Models;

namespace School.Api.Repositories.Interfaces
{
    /// <summary>
    /// Manages language data.
    /// </summary>
    public interface ILanguageRepository
    {
        /// <summary>
        /// Gets all languages.
        /// </summary>
        /// <returns>A list of languages.</returns>
        Task<List<LanguageModel>> GetLanguagesAsync();

        /// <summary>
        /// Gets a language by ID.
        /// </summary>
        /// <param name="languageId">The language ID.</param>
        /// <returns>The language.</returns>
        Task<LanguageModel> GetLanguageByIdAsync(int languageId);

        /// <summary>
        /// Adds a new language.
        /// </summary>
        /// <param name="language">The language to add.</param>
        /// <returns>The added language.</returns>
        Task<LanguageModel> AddLanguageAsync(LanguageModel language);

        /// <summary>
        /// Updates a language.
        /// </summary>
        /// <param name="languageId">The language ID.</param>
        /// <param name="language">The language details.</param>
        /// <returns>The updated language.</returns>
        Task<LanguageModel> UpdateLanguageAsync(int languageId, LanguageModel language);

        /// <summary>
        /// Deletes a language.
        /// </summary>
        /// <param name="languageId">The l
    }
}
