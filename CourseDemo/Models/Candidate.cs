using System.ComponentModel.DataAnnotations;
namespace CourseDemo.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is Required")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "First Name is Required")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last Name is Required")]
        public String? LastName { get; set; } = String.Empty;
        public string? FullName => $"{FirstName} {(LastName != null ? LastName.ToUpper() : "")}";
        public int? Age { get; set; } = null;

        public String? SelectedCourse { get; set; } = string.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
