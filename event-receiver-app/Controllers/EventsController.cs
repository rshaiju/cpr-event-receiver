using event_receiver_app.Hubs;
using event_receiver_app.Models;
using event_receiver_app.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace event_receiver_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IHubContext<CprEventsHub> hubContext;
        private readonly EventService eventService;

        public EventsController(IHubContext<CprEventsHub> hubContext, EventService eventService)
        {
            this.hubContext = hubContext;
            this.eventService = eventService;
        }

        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody]CprEvent cprEvent)
        {
            this.eventService.AddEvent(cprEvent);
            await this.hubContext.Clients.All.SendAsync("RefreshData");
            return Ok();
        }
    }
}
