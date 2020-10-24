namespace FCT.Data.Domain.Aviation
{
    public class Aircraft
    {
        public int Id { get; set; }
        public string TailNumber { get; set; }

        public int? AircraftModelId { get; set; }
        public AircraftModel AircraftModel { get; set; }
    }
}
