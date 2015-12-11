using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Strore_mArker
{
    public partial class Order 
    {
        public Order()
        {
            OrderID = Guid.NewGuid();
            Products= new List<Product>();
        }
        public Guid OrderID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double SumOrder { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public string KindPayment { get; set; }
        public string OrderAddress { get; set; }
        public int CostDelivery { get; set; }

        public virtual User User { get; set; }


        public virtual ICollection<Product> Products { get; set; } 

        public override string ToString()
        {
            return FirstName;
        }
    }
   }

