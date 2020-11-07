using CsvHelper.Configuration.Attributes;

namespace FCT.Data.Seeders.Models
{
    public class ZoneModel
    {
        [Index(0)]
        public int Id { get; set; }

        [Index(1)]
        public string CountryCode { get; set; }

        [Index(2)]
        public string ZoneName { get; set; }
    }
}
