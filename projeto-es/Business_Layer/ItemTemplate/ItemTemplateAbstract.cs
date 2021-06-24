using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;
using MySql.Data.MySqlClient;


namespace projeto_es.Business_Layer
{
    public abstract class ItemTemplateAbstract
    {
        private readonly MySqlConnection _conn;
        private string _connectionString = DbContext.GetMySQLConnectionString();

        public ItemTemplateAbstract()
        {
            _conn = new MySqlConnection(_connectionString);
        }

        public void addItem(int prescriptionID, string name, int weight,string session, int treat_time, int exercise_dur)
        {
            string queryInsertItem = $"INSERT INTO `item` (`id`, `name`, `type`, `weight`, `session`, `treat_time`, `exercise_dur`, `Prescription_id`) VALUES(NULL, '{name}', '', NULL, NULL, NULL, NULL, '{prescriptionID}')";
            
            this._conn.Query(queryInsertItem);

            if (WantsWeightToItem())
            {
                assignWeightToItem(prescriptionID, name, weight);
            }
            if (WantsSessionToItem())
            {
                assignSessionToItem(prescriptionID, name, session);
            }
            if (WantsTreatmentTimeToItem())
            {
                assignTreatmentTimeToItem(prescriptionID, name, treat_time);
            }
            if (WantsExerciseDurationToItem())
            {
                assignExerciseDurationToItem(prescriptionID, name, exercise_dur);
            }

        }

        abstract public void assignWeightToItem(int prescriptionID, string name, int weight);
        abstract public void assignTreatmentTimeToItem(int prescriptionID, string name, int treat_time);
        abstract public void assignExerciseDurationToItem(int prescriptionID, string name, int exercise_dur);
        abstract public void assignSessionToItem(int prescriptionID, string name, string session);

        //Hooks
        Boolean WantsWeightToItem() { return true; }
        Boolean WantsSessionToItem() { return true; }
        Boolean WantsTreatmentTimeToItem() { return true; }
        Boolean WantsExerciseDurationToItem() { return true; }
    }
}
