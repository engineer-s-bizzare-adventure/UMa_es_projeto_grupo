using Dapper;
using MySql.Data.MySqlClient;

namespace projeto_es.Business_Layer.Commands
{
    public class RegisterReceiver
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public RegisterReceiver()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public void RegisterPerson(string name, int age, string address) 
        {
            string sql = $"INSERT INTO person(name, age, address) VALUES ('{name}', {age}, '{address}')";
            this._conn.Execute(sql);
        }

        public void CreateAccount(string email, string password) 
        {
            string sql = $"INSERT INTO `account`(`email`, `password`, `Person_id`) VALUES ('{email}', '{password}', LAST_INSERT_ID())";
            this._conn.Execute(sql);
        }

        public void CreateClientAccount() 
        {
            string sql = $"INSERT INTO `clientaccount`(`Account_id`) VALUES (LAST_INSERT_ID())";
            this._conn.Execute(sql);
        }
    }
}
