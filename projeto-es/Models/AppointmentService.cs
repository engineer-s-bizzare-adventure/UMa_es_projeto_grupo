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


        public void CreateAppointment(Appointment Appointment)
        {

            string createAppointmentQuery = $"INSERT INTO `appointment` (`date`, `description`, `scheduled_time`, `StaffAccount_id`, `ClientAccount_id`) VALUES('{Appointment.date}', '{Appointment.description}', '{Appointment.scheduled_time}', 1, 1)";
            this._conn.Execute(createAppointmentQuery);
            //SELECT * FROM `staffaccount`, `account`, `person` WHERE staffaccount.Account_id = account.id && account.Person_id = person.id
        }
    }
}
