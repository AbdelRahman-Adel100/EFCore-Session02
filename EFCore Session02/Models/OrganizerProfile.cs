using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_Session02.Models
{
    internal class OrganizerProfile
    {
        public int OrganizerProfileId { get; set; }
        public string Biography { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }
    }
}
