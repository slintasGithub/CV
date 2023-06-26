using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Manager.DTOs.Degree;

namespace Manager.DTOs.Candidate
{
    public class CreateUpdateCandidateDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Mobiles phones must have exactly 10 numbers")]
        public string? Mobile { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DegreeDTO Degree { get; set; } = new DegreeDTO();
    }
}
