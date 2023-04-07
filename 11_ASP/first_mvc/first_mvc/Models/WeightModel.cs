using System.ComponentModel.DataAnnotations;

namespace first_mvc.Models
{
    public class WeightModel
    {
        [Key]
        public int Id { get; set; }
        public int Kettlebell { get; set; }
        public int Price { get; set; }
    }
}
