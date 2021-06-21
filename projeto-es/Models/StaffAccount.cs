using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public partial class StaffAccount
    {
        public uint Id { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
        public uint AccountId { get; set; }
        public uint AdminAccountId { get; set; }

    }
}
