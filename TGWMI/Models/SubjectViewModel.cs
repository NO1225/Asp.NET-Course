using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGWMI.Models
{
    public class SubjectViewModel
    {
        [Display(Name = "اسم المادة")]
        public string Name { get; set; }
    }
}
