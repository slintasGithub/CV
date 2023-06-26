using Manager.DTOs.Candidate;
using Manager.DTOs.Degree;
using Manager.Services.Candidate;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Manager.Service.Candidate
{
    public class CandidateService : CrudAppService<Manager.Entities.Candidate.Candidate, CandidateDTO, int, PagedAndSortedResultRequestDto, CreateUpdateCandidateDTO>, ICandidateService
    {
        public CandidateService(IRepository<Manager.Entities.Candidate.Candidate, int> repository) : base(repository)
        {
            
        }
    }
}
