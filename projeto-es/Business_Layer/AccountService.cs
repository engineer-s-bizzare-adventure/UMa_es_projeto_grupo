using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public class AccountService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public AccountService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public void CreateAccount(Account account)
        {
            string sql = $"INSERT INTO `account`(`email`, `password`, `Person_id`) VALUES ('{account.Email}', '{account.Password}', LAST_INSERT_ID())";
            this._conn.Execute(sql);
        }

        public Account FetchAccount(string email, string password)
        {
            string QueryLogIN = $"SELECT `id`, `email`, `password` FROM `account` WHERE account.email ='{email}' AND account.password = '{password}'";
            var account = this._conn.Query<Account>(QueryLogIN).FirstOrDefault();

            return account;
        }

        public List<Person> GetAllStaffMembers()
        {
            string QueryGetAllStaffMembers = "SELECT * " +
                                             "FROM staffaccount, account, person " +
                                             "WHERE staffaccount.Account_id = account.id " +
                                             "&& account.Person_id = person.id";

            List<Person> ListOfStaff = (List<Person>)this._conn.Query<Person>(QueryGetAllStaffMembers);

            return ListOfStaff;
        }
        public int GetStaffMembersID(int PersonId)
        {
            string QueryGetStaffMembersID = "SELECT * " +
                                             "FROM staffaccount, account, person " +
                                             "WHERE staffaccount.Account_id = account.id " +
                                             "&& account.Person_id = person.id" +
                                             $"&& person.id ={PersonId}";

            int StaffID = this._conn.Query<int>(QueryGetStaffMembersID).FirstOrDefault();

            return StaffID;
        }

        public int GetStaffMemberID(int accountID)
        {
            string QueryGetAdminMemberID = $"SELECT staffaccount.id FROM staffaccount, account WHERE staffaccount.Account_id = account.id && account.id = {accountID}";

            int AdminID = this._conn.Query<int>(QueryGetAdminMemberID).FirstOrDefault();
            return AdminID;
        }

        public int GetAdminMemberID(int accountID)
        {
            string QueryGetAdminMemberID = $"SELECT adminaccount.id FROM adminaccount, account WHERE adminaccount.Account_id = account.id && account.id = {accountID}";
            
            int AdminID = this._conn.Query<int>(QueryGetAdminMemberID).FirstOrDefault();
            return AdminID;
        }

        public Person GetAdminDataFromAccount(string email)
        {
            string QueryAdminData = $"SELECT * FROM adminaccount, account, person WHERE adminaccount.Account_id = account.id && account.Person_id = person.id && account.email='{email}'";
            var Person = this._conn.Query<Person>(QueryAdminData).FirstOrDefault();
            return Person;
        }

        public Person GetStaffDataFromAccount(string email)
        {
            string QueryStaffData = $"SELECT * FROM staffaccount, account, person WHERE staffaccount.Account_id = account.id && account.Person_id = person.id && account.email= '{email}'";
            var Person = this._conn.Query<Person>(QueryStaffData).FirstOrDefault();
            return Person;
        }

        public Person GetUserDataFromAccount(string email)
        {
            string QueryUserData = $"SELECT * FROM clientaccount, account, person WHERE clientaccount.Account_id = account.id && account.Person_id = person.id && account.email= '{email}'";
            var Person = this._conn.Query<Person>(QueryUserData).FirstOrDefault();

            return Person;
        }

        public int GetClientAccountId(int accountID)
        {
            string QueryClientAccountTable = $"SELECT clientaccount.id FROM clientaccount, account WHERE clientaccount.Account_id = account.id AND account.id = {accountID}";
            var fetchedID = this._conn.Query<int>(QueryClientAccountTable).FirstOrDefault();

            return fetchedID;
        }

        public List<Prescription> GetClientPrescriptions(int clientAccountID)
        {
            string QueryPrescriptions = $"SELECT prescription.id, prescription.name, prescription.description, prescription.date_prescribed FROM prescription, appointment WHERE prescription.Appointment_id = appointment.id AND appointment.ClientAccount_id = {clientAccountID}";
            List<Prescription> prescriptions = (List<Prescription>)this._conn.Query<Prescription>(QueryPrescriptions);

            return prescriptions;
        }
        public List<Prescription> GetClientPrescriptionsOfStaff(int StaffAccountID)
        {
            string QueryPrescriptions = $"SELECT prescription.id, prescription.name, prescription.description, prescription.date_prescribed FROM prescription, appointment WHERE prescription.Appointment_id = appointment.id AND appointment.StaffAccount_id = {StaffAccountID}";
            List<Prescription> prescriptions = (List<Prescription>)this._conn.Query<Prescription>(QueryPrescriptions);

            return prescriptions;
        }
    }
}
