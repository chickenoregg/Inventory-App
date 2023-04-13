using InventorySystemApp.Classes;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventorySystemApp.Forms
{
    public partial class ProductForm : Form
    {
       
        // properties
        MainForm mainForm = new MainForm();


        private Product product;
        private BindingList<Part> PartsListBinding;

        public ProductForm()
        {
            InitializeComponent();
            
            // feed the BL partslist to the top datagrid - datasource
            dataGridViewA.DataSource = Inventory.PartsList;


            if (product != null)
            {
                // convert to strings

                txtProductID.Text = product.ProductID.ToString();
                txtProductName.Text = product.Name.ToString();
                txtProductInventory.Text = product.Inventory.ToString();
                txtProductPrice.Text = product.Price.ToString();
                txtProductMax.Text = product.Max.ToString();
                txtProductMin.Text = product.Min.ToString();
            }
            else
            {
                product = new Product();
                product.AssociatedPartItems = new BindingList<Part>();
            }
            dataGridViewB.DataSource = product.AssociatedPartItems;

        }


        // to select a row on datagridpart
        private void GridPartIdx()
        {
            if (dataGridViewA.SelectedRows.Count != 0)
            {
                //assign the index selected on the datagrid to the datagridview
                DataGridViewRow gridRow = this.dataGridViewA.SelectedRows[0];
                Inventory.InventoryPartSelectedIndex = gridRow.Index;
            }
            else
            {
                Inventory.InventoryPartSelectedIndex = -1;
            }
  
        }

        // to select a row on associatedparts
        private void GridAssociatedPartIdx()
        {
            if (dataGridViewB.SelectedRows.Count != 0)
            {

                //assign the index selected on the datagrid to the datagridview
                DataGridViewRow row = this.dataGridViewB.SelectedRows[0];
                Inventory.InventoryPartSelectedIndex = row.Index;
            }
            else
            {
                Inventory.InventoryPartSelectedIndex = -1;
            }
 
        }


        // to save inputs once validated
        private bool LetSave()
        {
 
            if (!Inventory.IsValidString(txtProductName.Text))
            {
                return false;
            }
            if (!Inventory.IsValidInt(txtProductInventory.Text))
            {
                return false;
            }
            if (!Inventory.IsValidDecimal(txtProductPrice.Text))
            {
                return false;
            }
            if (!Inventory.IsValidInt(txtProductMax.Text))
            {
                return false;
            }
            if (!Inventory.IsValidInt(txtProductMin.Text))
            {
                return false;
            }
            if (!Inventory.ValidMinMax(txtProductInventory.Text, txtProductMax.Text, txtProductMin.Text))
            {
                return false;
            }
            return true;
        }

        //product name box selected
        //run the validations
        //allow to be saved
        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            bool isValidName = Inventory.IsValidString(txtProductName.Text);
            btnSaveProduct.Enabled = LetSave();
        }

        //product inventory box selected
        //run the validations
        //allow to be saved
        private void txtProductInventory_TextChanged(object sender, EventArgs e)
        {
            bool isValidInventory = Inventory.IsValidInt(txtProductInventory.Text) &&
           Inventory.ValidMinMax(txtProductInventory.Text, txtProductMax.Text, txtProductMin.Text);
            btnSaveProduct.Enabled = LetSave();

            
        }

        //product price box selected
        //run the validations
        //allow to be saved
        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {
            bool isValidPrice = Inventory.IsValidDecimal(txtProductPrice.Text);
            btnSaveProduct.Enabled = LetSave();

        }

        //product min box selected
        //run the validations
        //allow to be saved
        private void txtProductMin_TextChanged(object sender, EventArgs e)
        {
            bool isValidMin = Inventory.ValidMinMax(txtProductInventory.Text, txtProductMax.Text, txtProductMin.Text) && Inventory.IsValidInt(txtProductMin.Text);
            btnSaveProduct.Enabled = LetSave();
  
        }

        //product max box selected
        //run the validations
        //allow to be saved
        private void txtProductMax_TextChanged(object sender, EventArgs e)
        {
            bool isValidMax = Inventory.ValidMinMax(txtProductInventory.Text, txtProductMax.Text, txtProductMin.Text) &&
Inventory.IsValidInt(txtProductMax.Text);
            btnSaveProduct.Enabled = LetSave();

        }

        // to add product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            GridPartIdx();
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //add the selected part to the associatedpartitems
                Inventory.InventoryPartSelected = Inventory.PartsList[Inventory.InventoryPartSelectedIndex];
                product.AssociatedPartItems.Add(Inventory.InventoryPartSelected);
            }
            else
            {
                //raise an error
                MessageBox.Show("Please select a part to add.");
            }
            btnSaveProduct.Enabled = LetSave();
          
        }


        // to search a product
  
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //access the BL partsbindinglist

            BindingList<Part> PartsBindingList = new BindingList<Part>();

            //initialize to false
            bool isFound = false;

            //check is the input is empty
            if (txtSearchProduct.Text != "")
            {
                //loop through the BL partslist
                for (int i = 0; i < Inventory.PartsList.Count; i++)
                {
                    //checks if input name value is in the BL partslist 
                    if (Inventory.PartsList[i].Name.ToLower().Contains(txtSearchProduct.Text.ToLower()))
                    {
                        PartsBindingList.Add(Inventory.PartsList[i]);
                        isFound = true;
                    }
                }
                //if the value is found, feed the BL partsbindinglist to the datasource
                if (isFound)
                    dataGridViewA.DataSource = PartsBindingList;
            }
            if (!isFound)
            {
                //display the datagrid if not found

                dataGridViewA.DataSource = Inventory.PartsList;
            }
        }

        // to save the inputs once validated

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (product.ProductID == -1)
            {
                //Inhouse selected
                //run the validations
                //convert to their respective data types
                Product newProduct = new Product(txtProductName.Text, Convert.ToInt32(txtProductInventory.Text),
                    Convert.ToDecimal(txtProductPrice.Text),
                    Convert.ToInt32(txtProductMax.Text),
                    Convert.ToInt32(txtProductMin.Text));

                //add new product to the inventory
                Inventory.AddProductItem(newProduct);
                newProduct.AssociatedPartItems = product.AssociatedPartItems;
            }

            this.Close();
            this.Hide();
            mainForm.Show();
        }



        //to delete a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // selects the row - index 

            GridAssociatedPartIdx();
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //displays a confirmation message to the user if prompted and matches the result to yes

                DialogResult result = MessageBox.Show("Do you want to delete this part?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //removes the part via index

                    product.AssociatedPartItems.RemoveAt(Inventory.InventoryPartSelectedIndex);
                }
            }
            else
            {
                //raise an error message
                MessageBox.Show("Please select to delete.");
            }
            btnSaveProduct.Enabled = LetSave();
        }
        
        //to cancel the form
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            mainForm.Show();
        }


    }
}
