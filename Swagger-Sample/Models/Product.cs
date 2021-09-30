using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Swagger_Sample.Models
{
    public class Product

    {
        public Product() { }
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        [Required]
        public string Name { get; set; }
        [DefaultValue("Sem descrição")]
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
