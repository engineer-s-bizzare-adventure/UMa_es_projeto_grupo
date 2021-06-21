using MySql.Data.MySqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Models
{
    public class PersonService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public PersonService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public void InsertPerson()
        {
            string sql = "INSERT INTO person(name, age, address) VALUES ('Joao', 12, 'Rua das pretas')";
            this._conn.Execute(sql);

            //_conn.Open();
            //var cmd = new MySqlCommand();
            //cmd.Connection = _conn;
            //cmd.CommandText = sql;
            //cmd.Prepare();

            //cmd.ExecuteNonQuery();
            //_conn.Close();
            
        }
    }
}
