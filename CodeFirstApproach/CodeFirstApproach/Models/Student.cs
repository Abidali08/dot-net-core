using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Column("Std_Name",TypeName = "varchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column("Std_Email", TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; }

        [Column("Std_Phone", TypeName = "varchar(100)")]
        [Required]
        public string Phone { get; set; }

        [Column("Std_Address", TypeName = "varchar(100)")]
        [Required]
        public string Address { get; set; }

        [Column("Std_Semester", TypeName = "varchar(100)")]
        [Required]
        public int Semester { get; set; }
    }
}
