using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Name Must be Enter")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="Name must be 3-15")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Must be Enter")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age Must be Enter")]
        [Range(10,50,ErrorMessage ="Age must be between 10-50")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Password Must be Enter")]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$")]
        public string Password { get; set; }

    }
}
