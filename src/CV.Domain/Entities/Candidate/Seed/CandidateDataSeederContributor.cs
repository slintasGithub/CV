using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Manager.Entities.Candidate.Seed
{
    public class CandidateDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        public IRepository<Candidate, int> Repository { get; }

        public CandidateDataSeederContributor(IRepository<Candidate, int> _repository)
        {
            Repository = _repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (!(await Repository.AnyAsync()))
            {
                await Repository.InsertAsync(
                    new Candidate
                    {
                        FirstName = "Stefanos",
                        LastName = "Lintas",
                        Email = "stefanos.lidas@gmail.com",
                        Mobile = "6986194145",
                        DateCreated = DateTime.Now,
                    }
                );
                await Repository.InsertAsync(
                    new Candidate
                    {
                        FirstName = "Xristina",
                        LastName = "Xatzoglou",
                        Email = "christina.chatz@gmail.com",
                        Mobile = "6986194146",
                        DateCreated = DateTime.Now,
                    }
                );
                await Repository.InsertAsync(
                    new Candidate
                    {
                        FirstName = "Giannhs",
                        LastName = "Kokkinos",
                        Email = "giannis.kokkinos@gmail.com",
                        Mobile = "6986194147",
                        DateCreated = DateTime.Now,
                    }
                );
            }
        }
    }
}
