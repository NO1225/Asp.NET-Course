using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TGWMI.Data.Models
{
    public class StudentSubject
    {
        [Key]
        public int Id { get; set; }

        public Student Student { get; set; }

        [ForeignKey(nameof(Student))]
        [Required]
        public int StudentId { get; set; }

        public Subject Subject { get; set; }

        [ForeignKey(nameof(Subject))]
        [Required]
        public int SubjectId { get; set; }
    }
}
