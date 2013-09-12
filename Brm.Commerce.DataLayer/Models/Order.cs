using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brm.Commerce.DataLayer.Models
{
    public class Order
    {
        public int Id { get; set; }

        public virtual List<Service> Services { get; set; }
    }
}