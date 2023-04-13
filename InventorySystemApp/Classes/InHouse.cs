using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystemApp.Classes
{
    //inherits from Part class
    public class InHouse : Part
    {
        //constructors

        //constructor without ID - inherits from Part class
        public InHouse(string name, int inventory, decimal price, int max, int min, int machineID) : base(name, inventory, price, max, min)
        {
            MachinePartID = machineID;
        }

        //constructor with full parameters - inherits from Part class
        public InHouse(int partID, string name, int inventory, decimal price, int max, int min, int machineID) : base(partID, name, inventory, price, max, min)
        {
            MachinePartID = machineID;
        }


        //property
        public int MachinePartID { get; set; }
    }
}
