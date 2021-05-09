using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace event_receiver_app.Models
{
    public class PersonData
    {
        public string MasterCardNumber { get; set; }

        public NameData NameData { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string CprStatus { get; set; }

        public string CreditWarning { get; set; }
    }
}
