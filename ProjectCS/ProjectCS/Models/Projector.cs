namespace ProjectCS.Models
{
    public class Projector : Equipment
    {
        public int Lumens { get; set; }
        public bool Is4K { get; set; }

        public Projector(int id, string name, int lumens, bool is4K)
            : base(id, name)
        {
            Lumens = lumens;
            Is4K = is4K;
        }
    }
}