﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class QuoteVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }

        //public System.DateTime DateOfBirth { get; set; }
        //public int CarYear { get; set; }
        //public string CarMake { get; set; }
        //public string CarModel { get; set; }
        //public bool DUI { get; set; }
        //public int SpeedingTickets { get; set; }
        //public bool CoverageType { get; set; }
    }
}