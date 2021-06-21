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
        public Account CheckLogin(string email, string password)
        {
            string QueryLogIN = $"SELECT `email`, `password` FROM `account` WHERE account.email ='{email}' AND account.password = '{password}'";
            var account = this._conn.Query<Account>(QueryLogIN).FirstOrDefault();

            return account;
        }
    }
}
