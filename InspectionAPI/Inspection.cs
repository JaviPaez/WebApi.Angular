using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InspectionAPI
{
    public class Inspection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(200)]
        public string Comment { get; set; } = string.Empty;


        public int InspectionTypeId { get; set; }
        public InspectionType? InspectionType { get; set; }
    }
}