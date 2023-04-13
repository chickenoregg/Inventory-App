using InventorySystemApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemApp.Forms
{
    public partial class ModifyProductForm : Form
    {
        MainForm mainForm = new MainForm();

        // properties

        private Product product;
        private BindingList<Part> PartsListBinding;
        public ModifyProductForm()
        {
            InitializeComponent();

            product = Inventory.InventoryProductSelected;
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


                // outer loop through the associated part items 
                // inside loop through the partslist
                // use the UpdatePart method 
                for (int item = 0; item < product.AssociatedPartItems.Count; item++)
                {
                    Part prodPart = product.AssociatedPartItems[item];

                    for (int j = 0; j < Inventory.PartsList.Count; j++)
                    {
                        Part part = Inventory.PartsList[j];
                        //update
                        Inventory.UpdatePart(part, prodPart);
                    }
                }

                PartsListBinding = new BindingList<Part>();

                //loop through the BL associatedpartitems
                for (int item = 0; item < product.AssociatedPartItems.Count; item++)
                {
                    //add the new item to the BL 
                    PartsListBinding.Add(product.AssociatedPartItems[item]);
                }
            }
            
            else
            {
                //creates a new product
                product = new Product();
                product.AssociatedPartItems = new BindingList<Part>();
            }
            //associated items gets fed to the datagrid - datasource
            dataGridViewB.DataSource = product.AssociatedPartItems;
        }

        //method to select a row on datagridpart
        private void GridPartIndx()
        {
            if (dataGridViewA.SelectedRows.Count != 0)
            {
                //assign the index selected on the datagrid to the datagridview

                DataGridViewRow gridRow = this.dataGridViewA.SelectedRows[0];
                //assign the index
                Inventory.InventoryPartSelectedIndex = gridRow.Index;
            }
            else
            {
                //no row selected
                Inventory.InventoryPartSelectedIndex = -1;
            }
        }

        //method to select a row on datagridassociatedparts
        private void GridAssociatedPartIndex()
        {
            if (dataGridViewB.SelectedRows.Count != 0)
            {
                DataGridViewRow gridRow = this.dataGridViewB.SelectedRows[0];
                //assign the index
                Inventory.InventoryPartSelectedIndex = gridRow.Index;
            }
            else
            {
                //no row selected
                Inventory.InventoryPartSelectedIndex = -1;
            }
        }

        // method to save inputs once validated
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


        private void ModifyProductForm_Load(object sender, EventArgs e)
        {

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

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {            
            //access the BL partsbindinglist

            //initialize to false

            bool isFound = false;
            BindingList<Part> PartsListBinding = new BindingList<Part>();
            if (txtSearchProduct.Text != "")
            {
                //loop through the BL

                for (int item = 0; item < Inventory.PartsList.Count; item++)
                {
                    //checks if input product value is in the BL partslist 

                    if (Inventory.PartsList[item].Name.ToLower().Contains(txtSearchProduct.Text.ToLower()))
                    {
                        // adds the value to the BL

                        PartsListBinding.Add(Inventory.PartsList[item]);
                        isFound = true;
                    }
                }
                if (isFound)
                    //if the value is found, feed the BL partsbindinglist to the datasource

                    dataGridViewA.DataSource = PartsListBinding;
            }
            if (!isFound)
            {
                //if not found, display the datagrid
                dataGridViewA.DataSource = Inventory.PartsList;
            }
        }

        // to add a product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //sets the row - index
            GridPartIndx();
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //current part value gets added to the associated partitems
                Inventory.InventoryPartSelected = Inventory.PartsList[Inventory.InventoryPartSelectedIndex];
                product.AssociatedPartItems.Add(Inventory.InventoryPartSelected);
            }
            else
            {
                //raise an error messge
                MessageBox.Show("Please select a part to add.");
            }
            btnSaveProduct.Enabled = LetSave();
        }


        // to save all inputs
        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (product.ProductID == -1)
            {
                //Create product
                // convert to their respective data types
                Product newProduct = new Product(txtProductName.Text,
                    Convert.ToInt32(txtProductInventory.Text),
                    Convert.ToDecimal(txtProductPrice.Text),
                    Convert.ToInt32(txtProductMax.Text),
                    Convert.ToInt32(txtProductMin.Text));

                Inventory.AddProductItem(newProduct);
                newProduct.AssociatedPartItems = product.AssociatedPartItems;
            }
            else
            {
                // Modify product
                //convert to their respective data types 
                product.Name = txtProductName.Text;
                product.Inventory = Convert.ToInt32(txtProductInventory.Text);
                product.Price = Convert.ToDecimal(txtProductPrice.Text);
                product.Max = Convert.ToInt32(txtProductMax.Text);
                product.Min = Convert.ToInt32(txtProductMin.Text);
            }

            this.Close();
            this.Hide();
            mainForm.Show();
        }


        // to delete a product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // selects the row - index 

            GridAssociatedPartIndex();
            if (Inventory.InventoryPartSelectedIndex >= 0)
            {
                //displays a confirmation message to the user if prompted and matches the result to yes

                DialogResult result = MessageBox.Show("Do you want to delete this part?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //removes the via index

                    product.AssociatedPartItems.RemoveAt(Inventory.InventoryPartSelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
            btnSaveProduct.Enabled = LetSave();
        }

        // to cancel the form  and returns to main form
        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            mainForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
