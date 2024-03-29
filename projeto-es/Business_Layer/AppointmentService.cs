﻿using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public bool CheckExistingAppointments(LoggedInSingleton loggedSingleton)
        {
            string checkExistingAppointmentsQuery = "SELECT `description` FROM `appointment`,`clientaccount` , `account` WHERE appointment.ClientAccount_id = clientaccount.id && clientaccount.Account_id = account.id && account.id = " + $"{loggedSingleton.Account.Id}";

            var count = this._conn.Query(checkExistingAppointmentsQuery);

            Console.WriteLine(loggedSingleton.Account.Id);

            if (count.Count() > 0)
            {
                return true;
            }
            return false;

        }


        public bool CheckExistingAppointmentsStaff(LoggedInSingleton loggedSingleton)
        {
            string checkExistingAppointmentsOfStaffQuery = "SELECT `description` FROM `appointment`,`staffaccount` , `account` WHERE appointment.StaffAccount_id = staffaccount.id && staffaccount.Account_id = account.id && account.id = " + $"{loggedSingleton.Account.Id}";

            var count = this._conn.Query(checkExistingAppointmentsOfStaffQuery);

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
                                            $"VALUES('{Appointment.date}', '{Appointment.description}', '{Appointment.scheduled_time}', {Appointment.StaffAccountId}, {Appointment.ClientAccountId})";
            this._conn.Execute(createAppointmentQuery);
        }

        public void DeleteAppointment(uint id)
        {

            string deleteAppointmentQuery = $"DELETE `appointment` FROM `appointment` WHERE appointment.id = {id}";
            
            this._conn.Execute(deleteAppointmentQuery);


        }


        public List<Appointment> GetsAppointmentsOfAClient(int AccountID)
        {
            string GetAppointmentsOfAClient = $"SELECT `description`, appointment.id, scheduled_time FROM appointment, clientaccount, account" +
                $" WHERE appointment.ClientAccount_id = clientaccount.id && clientaccount.Account_id = account.id && account.id = {AccountID}";

            List<Appointment> ListOffAppointments = (List<Appointment>)this._conn.Query<Appointment>(GetAppointmentsOfAClient);
            return ListOffAppointments;
        }


        public List<Appointment> GetsAppointmentsOfAStaff(int AccountID)
        {
            string GetAppointmentsOfAStaff = "SELECT `description`, appointment.id, scheduled_time " +
                "FROM appointment, staffaccount, account " +
                "WHERE appointment.StaffAccount_id = staffaccount.id && staffaccount.Account_id = account.id " +
                $"&& account.id = {AccountID}";

            List<Appointment> ListOffAppointmentsOfStaff = (List<Appointment>)this._conn.Query<Appointment>(GetAppointmentsOfAStaff);
            return ListOffAppointmentsOfStaff;
        }
    }
}
