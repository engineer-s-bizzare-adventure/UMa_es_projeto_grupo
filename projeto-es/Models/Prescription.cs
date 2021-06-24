namespace projeto_es.Models
{
    public class Prescription
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DatePrescribed { get; set; }
        public uint Appointment_Id { get; set; }
    }
}
