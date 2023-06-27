using Manager.DTOs.Degree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Manager.DTOs.Candidate
{
    public class CandidateDTO : AuditedEntityDto<int>
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

        public DateTime DateCreated { get; set; }

        public DegreeDTO Degree { get; set; } = new DegreeDTO();
    }
}
