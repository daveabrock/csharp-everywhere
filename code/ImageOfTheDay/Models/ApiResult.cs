using System;

namespace ImageOfTheDay.Models
{
    public class ApiResult
    {
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string HdUrl { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
