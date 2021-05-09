using event_receiver_app.Hubs;
using event_receiver_app.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace event_receiver_app.Services
{
    public class EventService
    {
        private List<CprEventListViewModel> cprEvents = new List<CprEventListViewModel>();
        private readonly IHubContext<CprEventsHub> hubContext;

        public EventService(IHubContext<CprEventsHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public Task<CprEventListViewModel[]> GetEventstAsync()
        {
            return Task.FromResult(cprEvents.ToArray());
        }

        public async Task AddEventAsync(CprEvent cprEvent)
        {
            cprEvents.Add(new CprEventListViewModel {Time = DateTime.Now, CprEvent = cprEvent });
            await this.hubContext.Clients.All.SendAsync("RefreshData");
        }
    }
}
