using ProjectCS.Enums;

namespace ProjectCS.Models
{
    public abstract class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentStatus Status { get; set; }

        protected Equipment(int id, string name)
        {
            Id = id;
            Name = name;
            Status = EquipmentStatus.Available;
        }
    }
}