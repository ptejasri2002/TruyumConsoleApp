using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumModel
{
    public class cart2
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfAdd { get; set; }
        public double TotalAmount { get; set; }
        public int UserId { get; set; }
    }
}