using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XYZ.Models
{
    public class Receipt
    {
        public string Company { get; set; }

        public string OrderNumber { get; set; }

        public double Price { get; set; }

        public double Payed { get; set; }

        public double Change { get; set; }

        public string Description { get; set; }
    }
}
