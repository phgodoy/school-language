using System;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class EnrollmentModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ClassID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }

        [MaxLength(255)]
        public string PaymentStatus { get; set; }

        // Propriedades de navegação para as chaves estrangeiras
        public UserModel User { get; set; }
        public ClassModel Class { get; set; }
    }
}
