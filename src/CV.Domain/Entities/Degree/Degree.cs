using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Manager.Enums.Degree;
using Manager.Entities.Candidate;

namespace Manager.Entities.Degree
{
    public class Degree : AuditedAggregateRoot<int>
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int Id { get; set; }

        public DegreeType DegreeType { get; set; }

        public byte[] CV { get; set; }

        public int? CandidateId { get; set; } = null;

        [ForeignKey(nameof(CandidateId))]
        public virtual Manager.Entities.Candidate.Candidate? Candidate { get; set; } = null;
    }
}
