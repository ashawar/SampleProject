using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleApp.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [Email]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [Phone]
        [MaxLength(20)]
        public string Mobile { get; set; }
        public int? Age { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}