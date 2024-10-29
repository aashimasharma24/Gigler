using Gigler.Core.DataObjects;
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
        public IEnumerable<Question> Get(QuestionManager questionManager)
        {
            return questionManager.GetAll();
        }
    }
}
