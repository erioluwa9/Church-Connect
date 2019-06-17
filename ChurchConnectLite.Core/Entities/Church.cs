using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchConnectLite.Core.Entities
{
   public class Church
    {
        public int ID { get; set; }

        public int? DenominationId { get; set; }

        public int? StateId { get; set; }

        public int? CountryId { get; set; }
        public string Name   { get; set; }
        public int? Year { get; set; }

        public string About { get; set; }

        public string Email { get; set; }

        public string Phone1 { get; set; }
        public string Phone2 { get; set; }

        public string WorshipDays { get; set; }

        public string Website { get; set; }

        public string LogoUrl { get; set; }

        public string Address { get; set; }
        public string OnlineServiceUrl { get; set; }
        
        // Bank Account Details
        public string Account { get; set; }

        public string AccountName { get; set; }

        public string AccountNumber { get; set; }

        // Social Media Handle

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        // Navigation Properties

        public Country Country { get; set; }

        public State State { get; set; }
        public Denomination Denominations { get; set; }

        public ICollection<Minister> Ministers { get; set; }

        public ICollection<Image> Gallery { get; set; }

        public ICollection<Donation> Donations { get; set; }

        


    }
}
