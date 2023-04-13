using InventorySystemApp.Classes;
using InventorySystemApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // feeding the BL partslist and productlist to the datagrids' datasource
            dataGridViewPart.DataSource = Inventory.PartsList;
            dataGridViewProduct.DataSource = Inventory.ProductsList;

        }

        //Parts 

        // to add a part
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            Inventory.InventoryPartSelected = null;
            //opens the the new partform
            PartForm partForm = new PartForm();
            partForm.Show();
            this.Hide();
            

        }

        // method to select the row parts - index
        private void GridPartIdx()
        {
            //checks whether the row selected is NOT 0
            if (dataGridViewPart.SelectedRows.Count != 0)
            {
                // assign the selected row's index and feed it to the data type dataviewroom
                DataGridViewRow gridRow = this.dataGridViewPart.SelectedRows[0];
                //assign the index
                Inventory.InventoryPartSelectedIndex = gridRow.Index;
            }
            else
            {
                //no row selected
                Inventory.InventoryPartSelectedIndex = -1;
            }
     
        }

        // to update an item
        private void btnModifyPart_Click(object sender, EventArgs e)
        {
            // selects the row - index 
            GridPartIdx();
            
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //the index will be used to modify the correct part
                Inventory.InventoryPartSelected = Inventory.PartsList[Inventory.InventoryPartSelectedIndex];
                //opens the modifypartform 
                ModifyPartForm modifyPartForm = new ModifyPartForm();
                modifyPartForm.Show();
                this.Hide();
            }
            else
            {
                //raise an error message if row is not selected
                MessageBox.Show("Please select a row to modify");
            }

        }

 
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //to delete an item
        private void btnPartDelete_Click(object sender, EventArgs e)
        {

            // selects the row - index 
            GridPartIdx();
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //displays a confirmation message to the user if prompted and matches the result to yes
                DialogResult result = MessageBox.Show("Do you want to delete this part?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                  //removes the part via index
                    Inventory.PartsList.RemoveAt(Inventory.InventoryPartSelectedIndex);
                }
            }
            else
            {
                //raise an error message if row is not selected
                MessageBox.Show("Please select a row to delete");
            }

        }

        //to search for an item
        private void txtSearchPart_TextChanged(object sender, EventArgs e)
        {

            //access the BL partsbindinglist
            BindingList<Part> PartsBindingList = new BindingList<Part>();

            //initialize to false
            bool isFound = false;

            //check is the input is empty
            if (txtSearchPart.Text != "")
            {
                //loop through the BL partslist
                for (int i = 0; i < Inventory.PartsList.Count; i++)
                {
                    //checks if input name value is in the BL partslist 
                    if (Inventory.PartsList[i].Name.ToLower().Contains(txtSearchPart.Text.ToLower()))
                    {
                        // adds the value to the BL
                        PartsBindingList.Add(Inventory.PartsList[i]);
                        isFound = true;
                    }
                }
                //if the value is found, feed the BL partsbindinglist to the datasource
                if (isFound)
                    dataGridViewPart.DataSource = PartsBindingList;
            }
            if (!isFound)
            {
                //display the datagrid if not found
                dataGridViewPart.DataSource = Inventory.PartsList;
            }
        }

        // Products

        // method to select a row as an index
        
        private void GridProductIdx()

        //checks whether the row selected is NOT 0
        {
            if (dataGridViewProduct.SelectedRows.Count != 0)
            {
                // assign the selected row's index and feed it to the data type dataviewroom

                DataGridViewRow gridRow = this.dataGridViewProduct.SelectedRows[0];
                //assign the index
                Inventory.InventoryProductSelectedIndex = gridRow.Index;
            }
            else
            {
                //no row selected
                Inventory.InventoryProductSelectedIndex = -1;
            }

        }

        // to add a product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Inventory.InventoryProductSelected = null;
            //access the productform
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        // to search a product
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //access the BL partsbindinglist

            BindingList<Product> ProductBindingList = new BindingList<Product>();

            //initialize to false
            bool isFound = false;

            //check if the input is empty
            if (txtSearchProduct.Text != "")
            {
                //loop through the BL productslis
                for (int item = 0; item < Inventory.ProductsList.Count; item++)
                {
                    //checks if input name value is in the BL partslist 

                    if (Inventory.ProductsList[item].Name.ToLower().Contains(txtSearchProduct.Text.ToLower()))
                    {
                        // adds the value to the BL

                        ProductBindingList.Add(Inventory.ProductsList[item]);
                        isFound = true;
                    }
                }
                if (isFound)
                    //if the value is found, feed the BL partsbindinglist to the datasource

                    dataGridViewProduct.DataSource = ProductBindingList;
            }
            if (!isFound)
            {
                //if not found, display the datagrid
                dataGridViewProduct.DataSource = Inventory.ProductsList;
            }
        }



        //to delete a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            //selects the row - index
            GridProductIdx();
            // check if the index selected is => 0
            if (Inventory.InventoryProductSelectedIndex >= 0)
            {
                Inventory.InventoryProductSelected = Inventory.ProductsList[Inventory.InventoryProductSelectedIndex];
                if (Inventory.InventoryProductSelected.AssociatedPartItems.Count == 0)
                {
                    //prompts the user to confirm whether they want to delete the product
                    DialogResult result = MessageBox.Show("Do you want to delete this product?", "", MessageBoxButtons.YesNo);

                    //if the result matches yes
                    if (result == DialogResult.Yes)
                    {
                        //remove the product - index from the BL productlist
                        Inventory.ProductsList.RemoveAt(Inventory.InventoryProductSelectedIndex);
                    }
                }
                else
                {
                    //raise an error if the product contains a part
                    MessageBox.Show("Deleting product with parts associated is not allowed.");
                }
            }
            else
            {
                //raise an error message if row is not selected
                MessageBox.Show("Please select a row to delete");
            }
        }

        // exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // to update a product
        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            //selects the row - index
            GridProductIdx();
            if (Inventory.InventoryProductSelectedIndex >= 0)
            {
                //the value on index selected gets fed on the current product
                Inventory.InventoryProductSelected = Inventory.ProductsList[Inventory.InventoryProductSelectedIndex];
                this.Hide();
                //access the modifyproduct form
                ModifyProductForm modifyProductForm = new ModifyProductForm();
                modifyProductForm.Show();

            }
            else
            {
                //raise an error message if row is not selected
                MessageBox.Show("Please select a row to modify");
            }
        }

        private void dataGridViewPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
