using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_element_database.Elements
{
    public class Element
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfBound { get; set; }
        public Charge Charge { get; set; }
    }
    public enum Charge
    {
        Zero = 0,
        Positive,
        Negative
    }
}
