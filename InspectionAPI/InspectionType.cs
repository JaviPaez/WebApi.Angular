using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class InspectionType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = string.Empty;
    }
}