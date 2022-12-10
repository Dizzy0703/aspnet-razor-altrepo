using System.ComponentModel.DataAnnotations;

namespace RazorTests.Models
{
    public class Vessel
    {
        public int ID { get; set; }
        public string COSPARID { get; set; } = string.Empty;

        [Display(Name = "Launch Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string Designation { get; set; } = string.Empty;

        [Display(Name = "Intended Target")]
        public string IntendedTarget { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
