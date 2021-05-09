using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace event_receiver_app.Models
{
    public class CprEventListViewModel
    {
        public Guid Id { get; } = Guid.NewGuid();

        public DateTime Time { get; set; }

        public CprEvent CprEvent { get; set; }

        public string Json
        {
            get
            {
                return CprEvent!=null?JsonConvert.SerializeObject(CprEvent, Formatting.Indented) :string.Empty;
            }
        }
    }
}
