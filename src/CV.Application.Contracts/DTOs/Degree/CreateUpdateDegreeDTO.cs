using Manager.Enums.Degree;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Manager.DTOs.Degree
{
    public class CreateUpdateDegreeDTO
    {
        public int Id { get; set; }

        public int? CandidateId { get; set; }

        public DegreeType DegreeType { get; set; }

        public byte[] CV { get; set; }
    }
}
