namespace ProjectCS.Models
{
    public class Camera : Equipment
    {
        public int Resolution { get; set; }
        public bool HasFlash { get; set; }

        public Camera(int id, string name, int resolution, bool hasFlash)
            : base(id, name)
        {
            Resolution = resolution;
            HasFlash = hasFlash;
        }
    }
}