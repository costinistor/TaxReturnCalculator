using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxReturnCalculator
{
    class ClientsList
    {
        public List<Client> clients = new List<Client>();
    }

    class Client
    {
        public string name { get; set; }
        public double id { get; set; }
        public string pass { get; set; }
        public string secondPass { get; set; } 
    }
}
