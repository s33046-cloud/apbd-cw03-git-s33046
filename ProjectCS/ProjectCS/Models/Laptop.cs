namespace ProjectCS.Models
{
    public class Laptop : Equipment
    {
        public int Ram { get; set; }
        public string Processor { get; set; }

        public Laptop(int id, string name, int ram, string processor)
            : base(id, name)
        {
            Ram = ram;
            Processor = processor;
        }
    }
}