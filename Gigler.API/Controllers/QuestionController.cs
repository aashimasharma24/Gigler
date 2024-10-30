using Gigler.Core.DataObjects;
using Gigler.Core.DTOs;
using Gigler.Manager;
using Microsoft.AspNetCore.Mvc;

namespace Gigler.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger<QuestionController> _logger;

        public QuestionController(ILogger<QuestionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<QuestionDTO> Get(QuestionManager questionManager)
        {
            return questionManager.GetRandomV2();
        }
    }
}
