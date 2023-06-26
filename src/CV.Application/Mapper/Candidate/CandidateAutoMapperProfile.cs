using AutoMapper;
using Manager.DTOs.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mapper.Candidate
{
    public class CandidateAutoMapperProfile : Profile
    {
        public CandidateAutoMapperProfile() { 
            CreateMap<Manager.Entities.Candidate.Candidate, CandidateDTO>();
            CreateMap<Manager.Entities.Candidate.Candidate, CreateUpdateCandidateDTO>();
            CreateMap<CandidateDTO, CreateUpdateCandidateDTO>();
            CreateMap<CandidateDTO, Manager.Entities.Candidate.Candidate>();
            CreateMap<CreateUpdateCandidateDTO, Manager.Entities.Candidate.Candidate>();
        }
    }
}
