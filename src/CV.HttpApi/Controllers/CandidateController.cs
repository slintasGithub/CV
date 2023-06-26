using Manager.DTOs.Candidate;
using Manager.Services.Candidate;
using Manager.Services.Degree;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace CV.Controllers
{

    public class CandidateController : Controller
    {
        private const string ViewLocator = "Pages/Views/Candidates/";
        private readonly ICandidateService _candidateService;
        private readonly IDegreeService _degreeService;

        public CandidateController(ICandidateService candidateService, IDegreeService degreeService)
        {
            _candidateService = candidateService;
            _degreeService = degreeService;
        }

        public async Task<IActionResult> GetList()
        {
            var candidates = await _candidateService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto());
            var res = candidates.Items.ToList();

            var degrees = await _degreeService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto());
            var listDegrees = degrees.Items.ToList();
            res.ForEach(x => {
                x.Degree = listDegrees.FirstOrDefault(w => w.CandidateId == x.Id);
            });

            return PartialView(ViewLocator + "List.cshtml", res);
        }

        public IActionResult GetForm()
        {
            return PartialView(ViewLocator + "Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> SaveCandidate(CreateUpdateCandidateDTO candidate)
        {
            await this._candidateService.CreateAsync(candidate);

            return ForceRefresh();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            await this._candidateService.DeleteAsync(id);

            return this.Ok();
        }

        private IActionResult ForceRefresh()
        {
            var loc = HttpContext.Request.Host.ToString();
            return Redirect(loc);
        }
    }
}
