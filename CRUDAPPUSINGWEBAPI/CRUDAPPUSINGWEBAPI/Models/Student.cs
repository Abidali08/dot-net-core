using System.ComponentModel.DataAnnotations;

namespace CRUDAPPUSINGWEBAPI.Models
{

        public class Student
        {
            [Required]
            public int id { get; set; }
        [Required]
        public string studentName { get; set; }
        [Required]
        public string studentGender { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public int standard { get; set; }
        [Required]
        public string fatherName { get; set; }
        }

}
