using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Strore_mArker
{
    public partial class User
    {
        [Key]
        public Guid ID { get; set; }
        public User()
        {
            this.ID = Guid.NewGuid();
            this.Orders = new HashSet<Order>();
        }
        
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public override string ToString(){return Name;}                
    }
}
