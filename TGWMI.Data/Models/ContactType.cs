using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TGWMI.Data.Models
{
    public class ContactType
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string TypeName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
