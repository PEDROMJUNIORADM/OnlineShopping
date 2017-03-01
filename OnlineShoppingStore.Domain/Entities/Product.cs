using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Descric { get; set; }
        public decimal Price { get; set; }
        [Required (ErrorMessage ="Categoria Obrigatória")]
        public string Category { get; set; }
    }
}
