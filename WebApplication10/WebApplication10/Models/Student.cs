﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication10.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Column("StudentName",TypeName = "varchar(100)")]
        public string Name { get; set; }
        [Column("StudentGender", TypeName = "varchar(20)")]
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
