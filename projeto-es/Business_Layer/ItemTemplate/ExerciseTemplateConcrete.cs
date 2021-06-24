using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_es.Business_Layer
{
    class ExerciseTemplateConcrete : ItemTemplateAbstract
    {

        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public ExerciseTemplateConcrete()
        {
            _conn = new MySqlConnection(_connectionString);
        }


        public override void assignExerciseDurationToItem(int prescriptionID, string name, int exercise_dur)
        {
            string query = $"UPDATE `item` SET `exercise_dur` = '{exercise_dur}', type = 'exercise' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        public override void assignSessionToItem(int prescriptionID, string name, string session)
        {
            string query = $"UPDATE `item` SET `session` = '{session}' , type = 'exercise' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        public override void assignTreatmentTimeToItem(int prescriptionID, string name, int treat_time)
        {
            string query = $"UPDATE `item` SET  `treat_time` = '{treat_time}' , type = 'exercise' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }

        public override void assignWeightToItem(int prescriptionID, string name, int weight)
        {
            string query = $"UPDATE `item` SET `weight` = '{weight}', type = 'exercise' WHERE name = '{name}' AND Prescription_id = {prescriptionID}";
            this._conn.Query(query);
        }
    }
}
