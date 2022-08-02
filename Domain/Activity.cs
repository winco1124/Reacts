using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string? Title { get; set; }
        public string? Descript { get; set; }
        public string? Category { get; set; }
        public string? City { get; set; }
        public string? Venue { get; set; }
    }
}