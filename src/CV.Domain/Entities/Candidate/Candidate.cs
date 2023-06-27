using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Entities;

namespace Manager.Entities.Candidate
{
    public class Candidate : AuditedAggregateRoot<int>
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Mobiles phones must have exactly 10 numbers")]
        public string? Mobile { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
