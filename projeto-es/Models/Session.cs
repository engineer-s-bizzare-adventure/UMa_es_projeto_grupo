using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public class Session
    {
        public int clientID = 0;
        public Session (Account account, Person person)
        {
            Account = account;
            Person = person;
        }

        public Account Account { get; set; }
        public Person Person { get; set; }
    }
}
