using Manager.DTOs.Degree;
using Manager.Services.Degree;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace CV.Service.Degree
{
    public class DegreeService : CrudAppService<Manager.Entities.Degree.Degree, DegreeDTO, int, PagedAndSortedResultRequestDto, CreateUpdateDegreeDTO>, IDegreeService
    {
        public DegreeService(IRepository<Manager.Entities.Degree.Degree, int> repository) : base(repository)
        {

        }
    }
}
