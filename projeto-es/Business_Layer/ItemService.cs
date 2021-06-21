using MySql.Data.MySqlClient;
using Dapper;
using projeto_es.Models;
using System.Linq;
using System.Collections.Generic;

namespace projeto_es.Business_Layer
{
    public class ItemService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public ItemService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public List<Item> CheckPrescribedItemHistory()
        {
            string fetchAllItems = "SELECT * FROM item";
            var listOfItems = _conn.Query<Item>(fetchAllItems).ToList();

            return listOfItems;
        }
    }
}
