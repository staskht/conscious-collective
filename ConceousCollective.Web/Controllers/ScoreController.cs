using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTOs;

namespace ConceousCollective.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScoreController : Controller
    {
        private readonly IWikiRateAnswerService _wikiRateAnswerService;
        private readonly IMaterialsService _materialsService;

        public ScoreController(IWikiRateAnswerService wikiRateAnswerService, IMaterialsService materialsService)
        {
            _wikiRateAnswerService = wikiRateAnswerService;
            _materialsService = materialsService;
        }
        [HttpGet("Get/{material}/{companyName}")]
        public async Task<IActionResult> Get(string material, string companyName)
        {
            var companyTask = 
                 _wikiRateAnswerService.GetFashionTransparencyIndex(companyName);

            var materialTask = _materialsService.CalculateEnvironmentalIndex(material);

            await Task.WhenAll(companyTask, materialTask);

            var wikiRateAnswer = await companyTask;
            var materialImpactScore = await materialTask;

            if (wikiRateAnswer == null) 
            {
                return NotFound($"No data for {companyName}");
            }


            if (materialImpactScore == 0) 
            {
                return NotFound($"No data for {material}");
            }

            var overallScore = Math.Round((wikiRateAnswer.Value + materialImpactScore) / 2, 1);

            var response = new
            {
                Company = wikiRateAnswer.Company,
                CompanyScore = Math.Round(wikiRateAnswer.Value, 1),
                MaterialImpactScore = materialImpactScore,
                OverallScore = overallScore
            };
            return Ok(response);
        }
    }
}
