using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace School.Api.Models
{
    public class CourseModel
    {
        public int ID { get; set; }

        [MaxLength(255)]
        public string CourseName { get; set; }

        [MaxLength(-1)] // Permitir texto longo para CourseDescription
        public string CourseDescription { get; set; }

        public int CourseDuration { get; set; }

        public decimal Price { get; set; }

        [MaxLength(255)]
        public LanguageModel CourseLanguageID { get; set; }

        // Propriedade de navegação corrigida
        public UserModel LeadInstructorNavigationID { get; set; }

        public List<ClassModel> Classes { get; set; }
    }
}
