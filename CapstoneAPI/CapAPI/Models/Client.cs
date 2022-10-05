using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccsystems.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string Password { get; set; }
        public int AccessID { get; set; }
    }
}
