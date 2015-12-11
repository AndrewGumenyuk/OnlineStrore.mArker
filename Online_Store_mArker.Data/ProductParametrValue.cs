using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Strore_mArker;

namespace Online_Store_mArker.Data
{
    public class ProductParametrValue
    {
        [Key]
        public Guid ProductID { get; set; }

        public Guid ProductParametrID { get; set; }

        public ProductParametrValue(){}
        public ProductParametrValue(ProductParametr parametr)
        {
            this.ProductID = Guid.NewGuid();
            this.ProductParametrID = Guid.NewGuid();
            Definition = parametr;
        }

        public ProductParametrValue(ProductParametr parametr, Product product) : this(parametr)
        {
            Products = product;
        }
        public ProductParametrValue(ProductParametr parametr, string value) : this(parametr)
        {
            Value = value;
        }

        public ProductParametrValue(ProductParametr parametr, Product product1, string value) : this(parametr, product1)
        {
            Value = value;
        }

        public virtual Product Products { get; set; }
        public virtual ProductParametr Definition { get; set; }
        public string Value { get; set; }
        public override string ToString()
        {
            return Definition.ProductParametrName + ":  " + Value;
        }
    }
}
