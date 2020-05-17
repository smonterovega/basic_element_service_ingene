using System.ComponentModel.DataAnnotations;

namespace basic_element_database.Elements
{
    public class Element
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int MaxNumberOfBond { get; set; }
        [Required]
        public Charge Charge { get; set; }
    }
    public enum Charge
    {
        Zero = 0,
        Positive,
        Negative
    }
}
