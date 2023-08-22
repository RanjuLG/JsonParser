using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonParser
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Address> address { get; set; }
        public List<PhoneNumbers> phoneNumbers { get; set; }
    }
    public class  Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class PhoneNumbers
    {
        public string type { get; set; }
        public int number { get; set;}
    }
}
