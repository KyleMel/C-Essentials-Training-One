using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Essential_Training_One
{
    class School
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string Number { get; set; }
        string _twitterAddress;
        string TwitterAddress
        {
            //make sure the twitter address starts with an @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }
    }
}
