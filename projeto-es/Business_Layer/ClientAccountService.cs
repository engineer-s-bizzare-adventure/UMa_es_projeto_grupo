using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    class ClientAccountService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public ClientAccountService()
        {
            _conn = new MySqlConnection(_connectionString);
        }
        public void CreateClientAccount()
        {
            string sql = $"INSERT INTO `clientaccount`(`Account_id`) VALUES (LAST_INSERT_ID())";
            this._conn.Execute(sql);
        }
    }
}
