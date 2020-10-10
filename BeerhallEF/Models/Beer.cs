﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeerhallEF.Models
{
    class Beer
    {
        #region Properties
        public int BeerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? AlcoholByVolume { get; set; }
        public bool AlcoholKnown => AlcoholByVolume.HasValue;
        public decimal Price {get; set;} 

        #endregion
    }
}
