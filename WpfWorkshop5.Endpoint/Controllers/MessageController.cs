using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WpfWorkshop5.Endpoint.Services;
using WpfWorkshop5.Logic;

namespace WpfWorkshop5.Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        IMessageLogic logic;
        IHubContext<SignalRHub> hub;

        public MessageController(IMessageLogic logic, IHubContext<SignalRHub> hub)
        {
            this.logic = logic;
            this.hub = hub;
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
            this.hub.Clients.All.SendAsync("MessageCreated", value);
        }
    }
}
