namespace ProjectWebApp.Models
{
    public class UpdateStudentViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Department { get; set; }
    }
}
