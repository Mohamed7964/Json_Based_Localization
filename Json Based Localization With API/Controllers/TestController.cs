using Json_Based_Localization_With_API.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Json_Based_Localization_With_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IStringLocalizer<TestController> _localizer;

        public TestController(IStringLocalizer<TestController> localizer)
        {
            _localizer = localizer;
        }
        [HttpPost]
        public IActionResult Get(CreateTestDto dto)
        {
            var welcomeMessage = string.Format(_localizer["welcome"], dto.Name);
            return Ok(welcomeMessage);
        }
    }
}
