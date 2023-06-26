using AutoMapper;
using Manager.DTOs.Degree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mapper.Degree
{
    public class DegreeAutoMapperProfile : Profile
    {
        public DegreeAutoMapperProfile()
        {
            CreateMap<Manager.Entities.Degree.Degree, DegreeDTO>();
            CreateMap<Manager.Entities.Degree.Degree, CreateUpdateDegreeDTO>();
            CreateMap<DegreeDTO, CreateUpdateDegreeDTO>();
            CreateMap<DegreeDTO, Manager.Entities.Degree.Degree>();
            CreateMap<CreateUpdateDegreeDTO, Manager.Entities.Degree.Degree>();
        }
    }
}
