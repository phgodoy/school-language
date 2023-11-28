using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Api.Models;
using School.Api.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classService;

        public ClassController(IClassRepository classService)
        {
            _classService = classService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClassModel>>> GetClasses()
        {
            List<ClassModel> classes = await _classService.GetClassesAsync();

            return Ok(classes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClassModel>> GetClass(int id)
        {
            var classModel = await _classService.GetClassByIdAsync(id);

            if (classModel == null)
            {
                return NotFound(); 
            }

            return Ok(classModel);
        }

        [HttpPost]
        public async Task<ActionResult<ClassModel>> PostClass(ClassModel classModel)
        {
            ClassModel createdClass = await _classService.AddClassAsync(classModel);

            return CreatedAtAction("GetClass", new { id = createdClass.ID }, createdClass);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutClass(int id, ClassModel classModel)
        {
            try
            {
                var updatedClass = await _classService.UpdateClassAsync(id, classModel);

                if (updatedClass == null)
                {
                    return NotFound(); 
                }

                return Ok(updatedClass);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClass(int id)
        {
            var classModel = await _classService.DeleteClassAsync(id);

            if (classModel)
            {
                return NoContent(); // Retorne NoContent se a exclusão for bem-sucedida.
            }

            return NotFound(); // Retorne NotFound se a classe não for encontrada.
        }
    }
}