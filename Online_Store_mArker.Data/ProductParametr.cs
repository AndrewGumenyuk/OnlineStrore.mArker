using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Strore_mArker;

namespace Online_Store_mArker.Data
{
    public class ProductParametr
    {
        public ProductParametr()
        {
            this.ProductParametrID = Guid.NewGuid();
        }
        public Guid ProductParametrID { get; private set; }
        public string ProductParametrName { get; set; }

        public virtual ProductType ProductTypes { get; set; }
    }
}
