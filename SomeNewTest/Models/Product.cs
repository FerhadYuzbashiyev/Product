using System.ComponentModel.DataAnnotations;

namespace SomeNewTest.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Input a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Input a price")]
        public decimal? Price { get; set; }
    }
}
