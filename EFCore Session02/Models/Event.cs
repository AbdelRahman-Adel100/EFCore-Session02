using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Session02.Models
{
    internal class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

    }
}
