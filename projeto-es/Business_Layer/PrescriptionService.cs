using MySql.Data.MySqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_es.Models;

namespace projeto_es.Business_Layer
{
    public class PrescriptionService
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public PrescriptionService()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public Prescription GetPrescription(int prescriptionID)
        {
            string QueryPrescriptionData = $"SELECT * FROM prescription WHERE prescription.id = {prescriptionID}";
            var fetchedPrescription = this._conn.Query<Prescription>(QueryPrescriptionData).FirstOrDefault();

            return fetchedPrescription;
        }
        public void CreatePrescription(Prescription prescription)
        {
            string QueryCreatePrescription = "INSERT INTO `prescription`(`name`, `description`, `date_prescribed`, `Appointment_id`) " +
                                             $"VALUES ('{prescription.Name}','{prescription.Description}','{prescription.DatePrescribed}',{prescription.Appointment_Id});";
            this._conn.Execute(QueryCreatePrescription);
        }
    }
}
