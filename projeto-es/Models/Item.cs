using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public class Item
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? Weight { get; set; }
        public string Session { get; set; }
        public decimal? TreatTime { get; set; }
        public string ExerciseDur { get; set; }
        public uint PrescriptionId { get; set; }
    }
}
