using FortyFlavors.Core.Application.DTOs.DtoS;
using FortyFlavors.Core.Application.Intefaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FortyFlavors.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampaignContoller : ControllerBase
    {
        private readonly ICampaignService _campaignService;

        public CampaignContoller(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCampaigns()
        {
            var campaigns = await _campaignService.GetAllAsync();
            return Ok(campaigns);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCampaign([FromBody] CampaignDto campaign)
        {
            await _campaignService.CreateCampaignAsync(campaign);
            return Ok("Kampanya oluşturuldu");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> EndCampaign(int id)
        {
            await _campaignService.EndCampaignAsync(id);
            return NoContent();
        }
    }
}
