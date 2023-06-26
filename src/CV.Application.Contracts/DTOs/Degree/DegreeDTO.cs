using Manager.Enums.Degree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Manager.DTOs.Degree
{
    public class DegreeDTO : AuditedEntityDto<int>
    {
        public int Id { get; set; }

        public int? CandidateId { get; set; }

        public DegreeType DegreeType { get; set; }

        public byte[] CV { get; set; }


    }
}
