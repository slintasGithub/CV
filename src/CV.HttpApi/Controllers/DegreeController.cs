
using Manager.DTOs.Candidate;
using Manager.DTOs.Degree;
using Manager.Entities.Candidate;
using Manager.Enums.Degree;
using Manager.Services.Degree;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CV.Controllers
{
    public class DegreeController : Controller
    {
        private const string ViewLocator = "Pages/Views/Degree/";
        private readonly IDegreeService _degreeService;

        public DegreeController(IDegreeService degreeService)
        {
            _degreeService = degreeService;
        }

        public async Task<IActionResult> GetList()
        {
            var candidates = await _degreeService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto());
            var res = candidates.Items.ToList();


            
            return PartialView(ViewLocator + "List.cshtml", res);
        }

        public IActionResult GetForm()
        {
            return PartialView(ViewLocator + "Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> SaveDegree(CreateUpdateDegreeDTO candidate)
        {
            try
            {
                await this._degreeService.CreateAsync(candidate);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }

            return ForceRefresh();
        }

        [HttpPost]
        [Route("/Degree/UploadFile")]
        public async Task<IActionResult> UploadFile(int? CandidateId, DegreeType DegreeType, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                byte[] fileBytes;
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    fileBytes = memoryStream.ToArray();
                }

                var res = new CreateUpdateDegreeDTO();
                res.CandidateId = CandidateId;
                res.DegreeType = DegreeType;
                res.CV = fileBytes;

                return await SaveDegree(res);
            }

            return BadRequest("No file specified.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDegree(int id)
        {
            var res = await _degreeService.GetAsync(id);
            if(res != null && res.CandidateId != null)
            {
                return this.Content("You cannot delete a degree with a candidate");
            }
            await this._degreeService.DeleteAsync(id);

            return this.Ok();
        }

        private IActionResult ForceRefresh()
        {
            var loc = HttpContext.Request.Host.ToString();
            return Redirect(loc);
        }
    }
}
