using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace event_receiver_app.Data
{
    public class EventService
    {
        private List<CprEvent> cprEvents;

        public EventService()
        {
            var startDate = DateTime.Now;
            var rng = new Random();
            cprEvents = Enumerable.Range(1, 5).Select(index => new CprEvent
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<CprEvent[]> GetEventstAsync()
        {
            var rng = new Random();
            return Task.FromResult(cprEvents.ToArray());
        }

        public void AddEvent(CprEvent cprEvent)
        {
            cprEvents.Add(cprEvent);
        }
    }
}
