using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruyumModel
{
    public class Menu2
    {
        public int id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public string Category { get; set; }
        public bool FreeDelivery { get; set; }
    }
}
