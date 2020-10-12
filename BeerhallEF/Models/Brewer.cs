using System;
using System.Collections.Generic;

namespace BeerhallEF.Models
{
    public class Brewer
    {
        #region Properties
        public int BrewerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? DateEstablished { get; set; }
        public string Street { get; set; }
        public int? Turnover { get; set; }
        public Byte[] Timestamp { get; set; }
        public ICollection<Beer> Beers { get; private set; }
        public int NrOfBeer => Beers.Count;
        #endregion
        public Location Location {get; set;}
        public ICollection<Course> Courses { get; set; }

        #region Constructor
        public Brewer()
        {
            Beers = new HashSet<Beer>();
            Courses = new HashSet<Course>();
        }
        #endregion
    }
}
