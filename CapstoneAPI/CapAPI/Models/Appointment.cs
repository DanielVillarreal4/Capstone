using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccsystems.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClientID { get; set; }
        public int EmployeeID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Cancel { get; set; }
        public string Description { get; set; }
    }
}
