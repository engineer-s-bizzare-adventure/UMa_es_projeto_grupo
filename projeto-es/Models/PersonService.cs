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
        public void InsertPerson(Person person)
        {
            string sql = $"INSERT INTO person(name, age, address) VALUES ('{person.name}', {person.age}, '{person.address}')";
            this._conn.Execute(sql);
        }

        //public int GetLastPersonId()
        //{
        //    var SqlLastID = "SELECT id FROM person ORDER BY id DESC LIMIT 1";
        //    return this._conn.Execute(SqlLastID);
        //}
        //public void InsertPerson(string name, int age, string address)
        //{
        //    string sql = $"INSERT INTO person(name, age, address) VALUES ('{name}', {age}, '{address}')";
        //    this._conn.Execute(sql);          
        //}
    }
}
