using System.ComponentModel.DataAnnotations;

namespace ProjectWebApp.Models
{
    public class AddStudentViewModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Department { get; set; }
    }
}
