using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace TGWMI.Data.Models
{
    public class Contact 
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string FullName { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public ContactType ContactType { get; set; }

        [ForeignKey(nameof(ContactType))]
        [Required]
        public int ContactTypeId { get; set; }

    }
}
