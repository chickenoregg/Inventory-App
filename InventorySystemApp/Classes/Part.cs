using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemApp.Classes
{
    public class Part
    {


        //constructors


        // constructor with full parameters
        public Part(int partID, string name, int inventory, decimal price, int max, int min)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }

        // constructor without ID
        public Part(string name, int inventory, decimal price, int max, int min)
        {
            PartID = idCounter++;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }


        //properties
        // ID counter
        public static int idCounter = 1;
        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }

   
}
