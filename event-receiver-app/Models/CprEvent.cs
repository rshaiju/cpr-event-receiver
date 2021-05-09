using System;

namespace event_receiver_app.Models
{
    public class CprEvent
    {
        public string ReferenceNumber { get; set; }

        public string MessageId { get; set; }

        public string MessageType { get; set; }

        public PersonData PersonData { get; set; }

        public Address Address { get; set; }
    }
}
