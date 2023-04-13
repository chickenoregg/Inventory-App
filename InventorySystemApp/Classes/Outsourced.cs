using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemApp.Classes
{
    //inherits from Part class
    public class Outsourced : Part
    {

        //constructors

        //constructor without ID - inherits from Part class
        public Outsourced(string name, int inventory, decimal price, int max, int min, string company) : base(name, inventory, price, max, min)
        {
            Company = company;
        }

        //constructor with full parameter - inherits from Part class
        public Outsourced(int partID, string name, int inventory, decimal price, int max, int min, string company) : base(partID, name, inventory, price, max, min)
        {
            Company = company;
        }


        //property
        public string Company { get; set; }
    }
}
