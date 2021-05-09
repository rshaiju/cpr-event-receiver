using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace event_receiver_app.Models
{
    public class CprEventListViewModel
    {
        public DateTime Time { get; set; }

        public CprEvent CprEvent { get; set; }
    }
}
