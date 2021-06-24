using Dapper;
using MySql.Data.MySqlClient;
using System;

namespace projeto_es.Business_Layer
{
    class TreatmentTemplateConcrete : ItemTemplateAbstract
    {

        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public TreatmentTemplateConcrete()
        {
            _conn = new MySqlConnection(_connectionString);
        }


        public override void assignExerciseDurationToItem(int prescriptionID, string name, int exercise_dur){ }

        public override void assignSessionToItem(int prescriptionID, string name, string session)
        {
            string query = $"UPDATE `item` SET `session` = '{session}', type = 'treatment' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        public override void assignTreatmentTimeToItem(int prescriptionID, string name, int treat_time)
        {
            string query = $"UPDATE `item` SET `treat_time` = '{treat_time}', type = 'treatment' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        public override void assignWeightToItem(int prescriptionID, string name, int weight)
        {
            string query = $"UPDATE `item` SET `weight` = '{weight}' , type = 'treatment' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        Boolean WantsExerciseDuration() { return false; }


    }
}
