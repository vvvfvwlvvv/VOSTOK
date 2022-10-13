using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FactoryOrder
    {
        public string City { get; set; }
        public string Workshop { get; set; }
        public string Employee { get; set; }
        public string Brigade { get; set; }
        public string Shift { get; set; }

        public FactoryOrder(string city, string workshop, string employee, string brigade, string shift)
        {
            City = city;
            Workshop = workshop;
            Employee = employee;
            Brigade = brigade;
            Shift = shift;
        }
    }
}
