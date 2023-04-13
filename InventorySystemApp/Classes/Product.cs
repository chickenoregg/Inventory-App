using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemApp.Classes
{
    public class Product
    {
        //constructors

        //constructor with full parameters
        public Product(int productID, string name, int inventory, decimal price, int max, int min)
        {
            ProductID = productID;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;
        }
        //constructor without the ID

        public Product(string name, int inventory, decimal price, int max, int min)
        {
            ProductID = idCounter++;
            Name = name;
            Inventory = inventory;
            Price = price;
            Max = max;
            Min = min;

        }

  
        // empty constructor
        public Product()
        {
            ProductID = -1;
            Name = "";
            Inventory = 0;
            Price = 0;
            Max = 0;
            Min= 0;
        }


        //properties


        public BindingList<Part> AssociatedPartItems = new BindingList<Part>();

        public static int idCounter = 1;
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }


        // Methods
        
        // To add Associated Parts
        public void AddAssociatedPartItem(Part part)
        {
            // to add part to the BL assosciatedpartitems
            AssociatedPartItems.Add(part);
        }

        // To remove Associated Parts

        public bool DeleteAssociatedPartItem(int PartID)
        {
            // checks to if the ID matches the ID in associatedparts and assign it
            var partDelete = AssociatedPartItems.Where(x => x.PartID == PartID).FirstOrDefault();

            // if the ID is null
            if (partDelete == null)
            {
                //raise and error message
                MessageBox.Show($"{PartID} is not associated with the product selected");
            }
            //remove the id from the BL
            AssociatedPartItems.Remove(partDelete);
            //return bool
            return true;

        }

        // To search for Associated Parts

        public Part SearchAssociatedPartItems(int PartID)
        {
            //checks to if the ID matches the ID in associatedparts and assign it to be searched
            var partSearch = AssociatedPartItems.Where(x => x.PartID == PartID).FirstOrDefault();

            // if the ID is null
            if (partSearch == null)
            {
                //raise an error message
                MessageBox.Show($"{PartID} is not associated with the product selected");
            }
            // return value
            return partSearch;
            
        }

    }
}


