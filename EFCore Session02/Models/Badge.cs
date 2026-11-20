using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Session02.Models
{
    internal class Badge
    {
        public int BadgeId { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTierEnum Tier { get; set; }

    }
}
