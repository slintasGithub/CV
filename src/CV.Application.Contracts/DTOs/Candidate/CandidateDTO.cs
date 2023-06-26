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
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string? Mobile { get; set; }

        public DateTime DateCreated { get; set; }

        public DegreeDTO Degree { get; set; } = new DegreeDTO();
    }
}
