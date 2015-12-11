using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Online_Store_mArker.Data;

namespace Online_Strore_mArker
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; private set; }

        public Product()
        {
            this.ProductID = Guid.NewGuid();
            this.ProductParametrValues = new List<ProductParametrValue>();
        }
        public string ProductName { get; set; }
        public int Number { get; set; }
        public double Cost { get; set; }
        public int Units { get; set; }
        public string Description { get; set; }
        public byte[] Content { get; set; } //Row for image
        //public Image ImageOfProduct { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductParametrValue> ProductParametrValues { get; set; }
        public virtual ProductType ProductTypes { get; set; }
    }
}
