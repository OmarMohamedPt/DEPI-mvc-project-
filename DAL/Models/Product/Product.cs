using System.ComponentModel.DataAnnotations;

namespace DAL.Models.Product
{
    public class Product
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Id Required")]
        public string? name { get; set; }
        public string? description { get; set; }
        public decimal price { get; set; }

        public int quantity { get; set; }

        public int ReorederLever { get; set; }
    }
}
