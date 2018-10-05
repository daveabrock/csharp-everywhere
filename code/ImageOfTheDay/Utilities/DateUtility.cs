using System;

namespace ImageOfTheDay.Utilities
{
    public class DateUtility
    {
        // According to NASA, the Astronomy Picture of the Day (APOD)
        //   site launched on June 16, 1995. This method grabs a 
        //   random date starting at that date for use to pass to the API.
        public string GetRandomDateString()
        {
            var _randomGenerator = new Random();
            DateTime start = new DateTime(1995, 6, 16);
            var range = (DateTime.Today - start).Days;
            var randomDate = start.AddDays(_randomGenerator.Next(range));
            return randomDate.ToString("yyyy-MM-dd");
        }
    }
}
