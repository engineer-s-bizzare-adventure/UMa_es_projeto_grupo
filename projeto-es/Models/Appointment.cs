using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    class Appointment
    {
        public uint Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public TimeSpan ScheduledTime { get; set; }
        public uint StaffAccountId { get; set; }
        public uint ClientAccountId { get; set; }
    }
}
