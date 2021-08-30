using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Essential_Training_One
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophmore, Junior, Senior}
        public GradeLevels GradeLevel { get; set; }
    }
}
