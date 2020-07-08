using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TGWMI.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [Display(Name ="الاسم الكامل")]
        [MaxLength(100)]
        [Required]
        public string FullName { get; set; }

        [Display(Name ="رقم الهاتف")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name ="النوع")]
        public string ContactTypeName { get; set; }

    }
}
