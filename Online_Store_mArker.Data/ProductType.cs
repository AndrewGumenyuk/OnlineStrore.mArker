using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Store_mArker.Data;

namespace Online_Strore_mArker
{
    public class ProductType
    {
        public ProductType()
        {
            this.ProductTypeID = Guid.NewGuid();
            this.ProductParametrValues = new List<ProductParametrValue>();
            //this.Products = new List<Product>();
        }
        [Key]
        public Guid ProductTypeID { get; set; }

        public string Name { get; set; }
        public string Model { get; set; }
        
        public virtual ICollection<ProductParametrValue> ProductParametrValues { get; set; }
        //public virtual ICollection<Product> Products { get; set; }
    
    }
}
