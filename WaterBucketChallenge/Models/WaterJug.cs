using System.ComponentModel.DataAnnotations;

namespace WaterBucketChallenge.Models
{
    public class WaterJug
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "X value must be a positive number")]
        public int x_capacity { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Y value must be a positive number")]
        public int y_capacity { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Z value must be a positive number")]
        public int z_amount_wanted { get; set; }
    }
}
