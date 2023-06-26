using Manager.Entities.Degree.Seed.FileToRead;
using Manager.Enums.Degree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Manager.Entities.Degree.Seed
{
    public class DegreeDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        public IRepository<Degree, int> Repository { get; }

        public DegreeDataSeederContributor(IRepository<Degree, int> _repository)
        {
            Repository = _repository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (!(await Repository.AnyAsync()))
            {
                await Repository.InsertAsync(new Degree
                {
                    DegreeType = DegreeType.MSc,
                    CV = SeedFileReader.ReadPdfFile("slintasCV2023.pdf")
                });

                await Repository.InsertAsync(new Degree
                {
                    DegreeType = DegreeType.MSc,
                    CV = SeedFileReader.ReadPdfFile("slintasCV2023.pdf")
                });

                await Repository.InsertAsync(new Degree
                {
                    DegreeType = DegreeType.MSc,
                    CV = SeedFileReader.ReadPdfFile("slintasCV2023.pdf")
                });
            }
        }
    }
}
