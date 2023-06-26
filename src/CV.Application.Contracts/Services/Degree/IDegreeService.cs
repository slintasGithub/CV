using Manager.DTOs.Degree;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Manager.Services.Degree
{
    public interface IDegreeService : ICrudAppService<DegreeDTO, int, PagedAndSortedResultRequestDto, CreateUpdateDegreeDTO>
    {

    }
}
