using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Essential_Training_One
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LasstName { get; set; }
        public string Email { get; set; }

        public abstract float ComputeGradeAverage();

    }
}
