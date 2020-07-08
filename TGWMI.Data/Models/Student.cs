using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TGWMI.Data.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [Range(1,13)]
        public int Year { get; set; }

        public List<StudentSubject> StudentSubjects { get; set; }
    }
}
