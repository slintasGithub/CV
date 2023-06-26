using Manager.DTOs.Candidate;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Manager.Services.Candidate
{
    public interface ICandidateService : ICrudAppService<CandidateDTO, int, PagedAndSortedResultRequestDto, CreateUpdateCandidateDTO>
    {
    }
}
