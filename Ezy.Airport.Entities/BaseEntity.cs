namespace Ezy.Airport.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOn { get; set; } = DateTime.Now;
    }
}
