namespace projeto_es.Models
{
    public class LoggedInSingleton
    {
        public static LoggedInSingleton instance = null;
        public int clientID = 0;
        public int staffID = 0;
        public int adminID = 0;
        public string Role = "";
        public int appointmentId = 0;


        private LoggedInSingleton(Account account = null, Person person = null)
        {
            Account = account;
            Person = person;
        }

        public Account Account { get; set; }
        public Person Person { get; set; }

        public static LoggedInSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LoggedInSingleton();
            }
            return instance;
        }
    }
}
