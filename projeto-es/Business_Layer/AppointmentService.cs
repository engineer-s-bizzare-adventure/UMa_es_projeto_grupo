using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_es.Models;

namespace projeto_es.Models
{
    class AppointmentService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public AppointmentService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public bool CheckExistingAppointments(Session session)
        {
            string checkExistingAppointmentsQuery = "SELECT `description` FROM `appointment`,`clientaccount`WHERE ClientAccount_id = clientaccount.id && clientaccount.id = " + $"{session.Account.Id}";

            var count = this._conn.Query(checkExistingAppointmentsQuery);

            Console.WriteLine(session.Account.Id);

            if (count.Count() > 0)
            {
                return true;
            }
            return false;

        }

        public void CreateAppointment(Appointment Appointment)
        {

            string createAppointmentQuery = "INSERT INTO `appointment` " +
                                            "(`date`, `description`, `scheduled_time`, `StaffAccount_id`, `ClientAccount_id`) " +
                                            $"VALUES('{Appointment.date}', '{Appointment.description}', '{Appointment.scheduled_time}', 1, 1)";
            this._conn.Execute(createAppointmentQuery);
            //SELECT * FROM `staffaccount`, `account`, `person` WHERE staffaccount.Account_id = account.id && account.Person_id = person.id
        }
        public List<Appointment> GetsAppointmentsOfAClient(int AccountID)
        {
            string GetAppointmentsOfAClient = $"SELECT `description` FROM appointment, clientaccount, account" +
                $" WHERE appointment.ClientAccount_id = clientaccount.id && clientaccount.id = account.id && account.id = {AccountID}";

            List<Appointment> ListOffAppointments = (List<Appointment>)this._conn.Query<Appointment>(GetAppointmentsOfAClient);
            return ListOffAppointments;
        }
    }
}
