namespace School.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ClassModel
    {
        public int ID { get; set; }
        public int ClassNumber { get; set; }
        public int CourseID { get; set; }

        [MaxLength(255)]
        public string Schedule { get; set; }

        [MaxLength(255)]
        public string DayOfWeek { get; set; }

        [MaxLength(255)]
        public string Classroom { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public int MaxCapacity { get; set; }

        // Propriedades de navegação
        public CourseModel Course { get; set; }
    }
}
