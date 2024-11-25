namespace PatientManagementApp.Models
{
    public class Patients
    {
        public int PatientId { get; set; } // Primary Key
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required string Gender { get; set; }
        public required string Contact { get; set; }
        public required string Address { get; set; }
    }
}
