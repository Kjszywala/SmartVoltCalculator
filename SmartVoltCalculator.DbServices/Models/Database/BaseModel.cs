using System.ComponentModel.DataAnnotations;

namespace SmartVoltCalculator.DbServices.Models.Database
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool IsActive { get; set; }
        public string? Notes { get; set; }
        public string? Title { get; set; }
    }
}
