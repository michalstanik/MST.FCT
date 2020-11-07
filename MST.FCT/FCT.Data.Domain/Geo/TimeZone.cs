using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCT.Data.Domain.Geo
{
    public class TimeZone
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public long TimeStart { get; set; }
        public long GMTOffset { get; set; }
        public int Dst { get; set; }

        /// <summary>
        /// Navigation properties to Zone
        /// </summary>
        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
    }
}
