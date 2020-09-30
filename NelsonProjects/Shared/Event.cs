using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NelsonProjects.Shared
{
    public class Event
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }
        
        public string Location { get; set; }

        public IEnumerable<string> AttendingList { get; set; }
    }
}
