using CsvHelper.Configuration.Attributes;

namespace FCT.Data.Seeders.Models
{
    public class TimeZoneModel
    {
        [Index(0)]
        public int Id { get; set; }
        [Index(1)]
        public string Abbreviation { get; set; }
        [Index(2)]
        public long TimeStart { get; set; }
        [Index(3)]
        public long GMTOffset { get; set; }
        [Index(4)]
        public int Dst { get; set; }
    }
}
