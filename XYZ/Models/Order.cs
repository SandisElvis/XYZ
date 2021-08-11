using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XYZ.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }

        public int UserId { get; set; }

        public double PayableAmount { get; set; }

        public string PaymentGateway { get; set; }

        public string OptionalDescription { get; set; }

    }
}
