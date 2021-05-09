using event_receiver_app.Models;
using event_receiver_app.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace event_receiver_app.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventService eventService;

        public EventsController(EventService eventService)
        {
            this.eventService = eventService;
        }

        [HttpGet]
        public async Task<IActionResult> GetEvents()
        {
            var events=await this.eventService.GetEventstAsync();
            return Ok(events);
        }


        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody]CprEvent cprEvent)
        {
            await this.eventService.AddEventAsync(cprEvent);

            return Ok();
        }
    }
}
