namespace School.Api.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public int UserRole { get; set; }
        public int Status { get; set; }

       public List<EnrollmentModel> Enrollments { get; internal set; }
    }
}