using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories.Interfaces;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepository _languageService;

        public LanguageController(ILanguageRepository languageService)
        {
            _languageService = languageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LanguageModel>>> GetStudents()
        {
            List<LanguageModel> Languages = await _languageService.GetLanguagesAsync();

            return Ok(Languages);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LanguageModel>> GetStudent(int id)
        {
            var Language = await _languageService.GetLanguageByIdAsync(id);

            return Ok(Language);
        }

        [HttpPost]
        public async Task<ActionResult<LanguageModel>> PostStudent(LanguageModel language)
        {
            LanguageModel Language = await _languageService.AddLanguageAsync(language);

            return Ok(Language);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, LanguageModel language)
        {
            var Language = await _languageService.UpdateLanguageAsync(id, language);

            return Ok(Language);

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _languageService.DeleteLanguageAsync(id);

            return Ok(student);
        }

    }
}
