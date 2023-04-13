using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemApp.Classes
{
    public static class Inventory
    {
  

        //properties binding lists
        public static BindingList<Part> PartsList = new BindingList<Part>();
        public static BindingList<Product> ProductsList = new BindingList<Product>();

        // getter and setter property parts
        public static Part InventoryPartSelected { get; set; }
        public static int InventoryPartSelectedIndex { get; set; }
        public static int InventoryPartSelectedID { get; set; }

        // getter and setter property products

        public static Product InventoryProductSelected { get; set; }
        public static int InventoryProductSelectedIndex { get; set; }
        public static int InventoryProductSelectedID { get; set; }

        // to swap inputs
        internal static void PassItems(Part Part)
        {
            // assign to exchange items 
            PartsList.Insert(InventoryPartSelectedIndex, Part);
            PartsList.RemoveAt(InventoryPartSelectedIndex + 1);
        }

        //Parts Methods


        // To Add part to the list
        public static void AddPart(Part part)
        {
            //add part to the BL partslist
            PartsList.Add(part);
        }

        // To delete part from the list

        public static bool DeletePart(Part part)
        {
            //initialize bool to false
            bool isValid = false;
            
            //loop through the BL partslist
            foreach (Part item in PartsList)
            {
                //check whether ID's matched
                if (item.PartID == part.PartID)
                {
                    // delete the ID from the BL partslist
                    PartsList.Remove(item);
                    //return bool as true
                    isValid = true;
                }
                else
                {
                    //raise and error message
                    MessageBox.Show("This is invalid");
                    isValid = false;
                }
            }
            //return bool
            return isValid;
        }
        
        // To search for a part from the list

        public static Part LookUpPart(int PartID)
        {
            //loop through each item in BL partslist
            foreach (Part item in PartsList)
            {
                //check is the ID's matched
                if (item.PartID == PartID)
                {
                    //return value
                    return item;
                }
                else
                {
                    //raise an error message
                    MessageBox.Show("This is invalid input");
                }
            }
            return null;

        }

        //To update parts value from the list
        public static void UpdatePart(Part partItem, Part productPartItem)
        {
            // reassign the input based on the user's input

            // part ID gets updated
            int partId = partItem.PartID;
            int prodPartID = productPartItem.PartID;

            // part name gets updated
            string name = partItem.Name;
            string prodPartName = productPartItem.Name;

            // inventory gets updated
            int inventory = partItem.Inventory;
            int prodPartInventory = productPartItem.Inventory;

            //price / cost gets updated
            decimal price = partItem.Price;
            decimal prodPartPrice = productPartItem.Price;

            //max value gets updated
            int max = partItem.Max;
            int prodPartMax = productPartItem.Max;

            //min value gets updated
            int min = partItem.Min;
            int prodPartMin = productPartItem.Min;

            if (partId == prodPartID)
            {
                //if any does not satisfy
                if ((name != prodPartName) ||
                    (inventory != prodPartInventory) ||
                    (price != prodPartPrice) ||
                    (max != prodPartMax) ||
                    (min != prodPartMin))
                {
                    //perform remove and add the items
                    InventoryProductSelected.AssociatedPartItems.Remove(productPartItem);
                    InventoryProductSelected.AssociatedPartItems.Add(partItem);
                }
            }
        }

        //Product Methods

        // To add Product

        public static void AddProductItem(Product product)
        {
            ProductsList.Add(product);
        }

        // To delete product from product list

        public static bool DeleteProductItem(int ProductID)
        {
            bool isValid = false;

            foreach (Product item in ProductsList)
            {
                //check if ID's match
                if (ProductID == item.ProductID)
                {
                    //remove the product from the list
                    ProductsList.Remove(item);
                    isValid = true;
                }
                else
                {
                    //raise an error message if no match
                    MessageBox.Show("Try again, product does not exist");
                    isValid = false;
                }
            }
            //return true
            return isValid;
        }

        // To Modify product from the list

        public static void UpdateProduct(int InventoryProductSelectedIndex, Product InventoryProductSelected)
        {
            // update the inputs based on the index - user's input
            ProductsList.Insert(InventoryProductSelectedIndex, InventoryProductSelected);
            ProductsList.RemoveAt(InventoryProductSelectedIndex);
        }

        // To search for product from the list

        public static Product SearchProductItem(int ProductID)
        {
            //loop through the items in the BL productlist
            foreach (Product item in ProductsList)
            {
                //check if the ID's matched
                if (item.ProductID == ProductID)
                {
                    //return value
                    return item;
                }
            }
            return null;
        }


        //methods to validate inputs

        //checks whether the input is a valid string
        public static bool IsValidString(string stringtext)
        {
            return !string.IsNullOrWhiteSpace(stringtext);
        }

        //checks whether the input os a valid int
        public static bool IsValidInt(string stringtext)
        {
            //checks if a valid string AND valid integer input
            int number;
            return IsValidString(stringtext) && Int32.TryParse(stringtext, out number);
        }
        public static bool IsValidDecimal(string stringtext)
        {
            //checks if a valid string AND valid decimal input
            decimal dec;
            return IsValidString(stringtext) && Decimal.TryParse(stringtext, out dec);
        }

        //checks if the input satisfies the requirement for inventory, max, and amin
        public static bool ValidMinMax(string inventory, string max, string min)
        {
            int Inventory;
            int Max;
            int Min;

            // since these are in string form, convert them to integer
            Int32.TryParse(inventory, out Inventory);
            Int32.TryParse(max, out Max);
            Int32.TryParse(min, out Min);

            //checks if requirements are met
            return (Inventory >= Min) && (Max >= Inventory);
        }

 

        




    }
}
