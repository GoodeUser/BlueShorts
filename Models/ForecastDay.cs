using System;
using System.Collections.Generic;

namespace BlueShorts.Models
{
    public class ForecastDay
    {
        public DateTime Date { get; set; }
        public DayDto Day { get; set; }
        public IEnumerable<ForecastHour> Hour { get; set; }

        public class DayDto
        {
            public float MaxtempF { get; set; }
            public float MintempF { get; set; }
        }
    }
}