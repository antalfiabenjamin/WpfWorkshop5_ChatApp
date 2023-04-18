using Microsoft.AspNetCore.Mvc;
using WpfWorkshop5.Logic;

namespace WpfWorkshop5.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageLogic logic;

        public MessageController(IMessageLogic logic)
        {
            this.logic = logic;
        }

        // GET: api/<MessageController>
        [HttpGet]
        public IEnumerable<Message> ReadAll()
        {
            return this.logic.ReadAll();
        }

        // POST api/<MessageController>
        [HttpPost]
        public void Create([FromBody] Message value)
        {
            this.logic.Create(value);
        }
    }
}
