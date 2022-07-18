using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        [Display(Name = "Product")]
        public int ProductID { get; set; }
        public virtual Product Product{ get; set; }
        [Display(Name = "Piece")]
        public int Quantity { get; set; }
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Display(Name = "Date")]
        public DateTime Date { get; set; }
        [Display(Name = "Picture")]
        public string Image { get; set; }
        [Display(Name = "User")]
        public int UserId { get; set; }

    }
}
