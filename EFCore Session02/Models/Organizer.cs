using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_Session02.Models
{
    [Table("EventOrganizers")]
    internal class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }
    }
}
