using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.DateAndTime
{
    internal class DateTimeClass
    {
        public static void Main(string[] args)
        {
            DateTime val = DateTime.Now;
            Console.WriteLine(val.ToString("yyyy/M/dd"));
            DateTime datewithutc= DateTime.UtcNow;
            Console.WriteLine(datewithutc.ToString());

          
            DateTime value1 = DateTime.Parse("03-12-2025 15:30");
            Console.WriteLine("Parse result: " + value1.ToString("dd-MM-yyyy HH:mm:ss"));
            TimeZoneInfo indianTime = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime value2 = DateTime.ParseExact(
                "03-12-2025",
                "dd-MM-yyyy",
             CultureInfo.CreateSpecificCulture("en-IN")
            );
            Console.WriteLine("Parse == result: " + value1.ToString("dd-MM-yyyy HH:mm:ss"));



            //utc to ist
            DateTimeOffset utctime = DateTimeOffset.Now;
            Console.WriteLine(utctime.ToString("hh:mm"));

            DateTimeOffset indianTime1 = utctime.ToOffset(TimeSpan.FromHours(5.5));
            Console.WriteLine(indianTime1.ToString("HH:mm"));
        }
    }
}
