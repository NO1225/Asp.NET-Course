using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGWMI.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Display(Name ="اسم الطالب")]
        public string FullName { get; set; }

        public List<SubjectViewModel> Subjects { get; set; }

    }
}
