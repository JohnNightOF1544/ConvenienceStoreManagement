using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
