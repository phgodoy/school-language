using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class PaymentModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime PaymentDate { get; set; }

        public decimal PaymentAmount { get; set; }

        [MaxLength(255)]
        public string PaymentMethod { get; set; }

        public int RelatedEnrollmentID { get; set; }

        public UserModel User { get; set; }
        public EnrollmentModel RelatedEnrollment { get; set; }
    }
}