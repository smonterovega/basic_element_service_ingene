using System;
using System.Collections.Generic;
using System.Text;

namespace basic_element_structure_engine.Elements
{
    public class Element
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxNumberOfBound { get;  set; }
        public Charge Charge { get;  set; }
    }
    public enum Charge
    {
        Zero = 0,
        Positive,
        Negative
    }
}

