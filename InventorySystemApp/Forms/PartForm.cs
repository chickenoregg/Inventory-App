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
    public partial class PartForm : Form
    {
        MainForm mainForm = new MainForm();

        private bool SelectInHouse;

        private Part part;


        public PartForm()
        {
            InitializeComponent();

            part = Inventory.InventoryPartSelected;

            // displays the input to the textboxes as strings
            if (part != null)
            {
                txtPartID.Text = part.PartID.ToString();
                txtPartName.Text = part.Name.ToString();
                txtPartInventory.Text = part.Inventory.ToString();
                txtPartPrice.Text = part.Price.ToString();
                txtPartMax.Text = part.Max.ToString();
                txtPartMin.Text = part.Min.ToString();

                // when InHouse is selected -- InHouse radiobutton 
                //cast part to Inhouse

                if (Inventory.InventoryPartSelected is InHouse)
                {
                    InHouse inHouse = (InHouse)part;
                    txtPartMachineID.Text = inHouse.MachinePartID.ToString();
                    SelectInHouse = true;
                    rbtnInHouse.Checked = true;

                }
                else
                {
                    // otherwise, Outsourced selected -- Outsourced radiobutton
                    //cast part to Outsourced

                    Outsourced e = (Outsourced)part;
                    txtPartMachineID.Text = e.Company;
                    SelectInHouse = false;
                    rbtnOutsourced.Checked = true;
                }
            }

        }

        //to select In House option
        private void rbtnInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Machine ID";
            SelectInHouse = true;
            bool isValidMachineID = Inventory.IsValidInt(txtPartMachineID.Text);
            btnSavePart.Enabled = LetSave();


        }
        //to select the Outsourced option
        private void rbtnOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Company Name";
            SelectInHouse = false;
            bool isValidCompany = Inventory.IsValidString(txtPartMachineID.Text);
            btnSavePart.Enabled = LetSave();
        }

        // method to save inputs
        private bool LetSave()
        {
            if (SelectInHouse)
            {
                //checks if the Machinebox - valid integer

                if (!Inventory.IsValidInt(txtPartMachineID.Text))
                {
                    return false;
                }
            }
            //checks if the machinebox - valid string

            if (!Inventory.IsValidString(txtPartMachineID.Text))
            {
                return false;
            }
            //checks if the namebox - valid string

            if (!Inventory.IsValidString(txtPartName.Text))
            {
                return false;
            }
            //checks if the inventorybox - valid integer

            if (!Inventory.IsValidInt(txtPartInventory.Text))
            {
                return false;
            }
            //checks if the pricebox - valid decimal

            if (!Inventory.IsValidDecimal(txtPartPrice.Text))
            {
                return false;
            }
            //checks if the maxbox - valid integer

            if (!Inventory.IsValidInt(txtPartMax.Text))
            {
                return false;
            }
            //checks if the minbox - valid integer

            if (!Inventory.IsValidInt(txtPartMin.Text))
            {
                return false;
            }
            //checks if the inventory, max, and min - valid range

            if (!Inventory.ValidMinMax(txtPartInventory.Text, txtPartMax.Text, txtPartMin.Text))
            {
                return false;
            }
            return true;
        }


        //part name box selected
        //run the validations
        //allow to be saved
        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            bool isValidName = Inventory.IsValidString(txtPartName.Text);
            btnSavePart.Enabled = LetSave();
        }

        //part inventory box selected
        //run the validations
        //allow to be saved
        private void txtPartInventory_TextChanged(object sender, EventArgs e)
        {
            //checks if all validations pass
            try
            {
               
                bool isValidInventory = Inventory.IsValidInt(txtPartInventory.Text) &&
           Inventory.ValidMinMax(txtPartInventory.Text, txtPartMax.Text, txtPartMin.Text);
                btnSavePart.Enabled = LetSave();
            }
            catch (Exception)
            {
                //raise an error if requirements not satisfied
                MessageBox.Show("Inventory must be between Max and Min");
            }     
        }


        //part price selected
        //run the validations
        //allow to be saved
        private void txtPartPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //checks if all validations pass
                bool isValidPrice = Inventory.IsValidDecimal(txtPartPrice.Text);
                btnSavePart.Enabled = LetSave();
            }
            catch (Exception)
            {
                //raise and error message
                MessageBox.Show("Numbers only");
            }
            
        }
        //part max selected
        //run the validations
        //allow to be saved
        private void txtPartMax_TextChanged(object sender, EventArgs e)
        {
            //checks if all validations pass

            try
            {
                bool isValidMax = Inventory.ValidMinMax(txtPartInventory.Text, txtPartMax.Text, txtPartMin.Text) &&
            Inventory.IsValidInt(txtPartMax.Text);
                btnSavePart.Enabled = LetSave();
            }
            catch (Exception)
            {
                //raise and error message

                MessageBox.Show("Numbers only");
            }
            
        }

        //part min selected
        //run the validations
        //allow to be saved
        private void txtPartMin_TextChanged(object sender, EventArgs e)
        {
            //checks if all validations pass

            try
            {
                bool isValidMin = Inventory.ValidMinMax(txtPartInventory.Text, txtPartMax.Text, txtPartMin.Text) && Inventory.IsValidInt(txtPartMin.Text);
                btnSavePart.Enabled = LetSave();
            }
            catch (Exception)
            {
                //raise and error message

                MessageBox.Show("Numbers only");
            }
            
        }

        //part machineid selected
        //run the validations
        //allow to be saved
        private void txtPartMachineID_TextChanged(object sender, EventArgs e)
        {
            if (SelectInHouse)
            {
                //checks the validations -  set to int

                bool isMachineID = Inventory.IsValidInt(txtPartMachineID.Text);
            }
            else
            {
                //checks the validations - set to string

                bool isCompanyName = Inventory.IsValidString(txtPartMachineID.Text);
            }
            btnSavePart.Enabled = LetSave();
        }

        // to save the inputs once validated
        private void btnSavePart_Click(object sender, EventArgs e)
        {
            if (part == null)
            {
                      //Inhouse selected
                //run the validations
                //convert to their respective data types
                //allow to be saved
                if (SelectInHouse)
                {
                    InHouse inHouse = new InHouse(txtPartName.Text, Convert.ToInt32(txtPartInventory.Text), Convert.ToDecimal(txtPartPrice.Text), Convert.ToInt32(txtPartMax.Text), Convert.ToInt32(txtPartMin.Text), Convert.ToInt32(txtPartMachineID.Text));

                    Inventory.AddPart(inHouse);
                }
                else
                {
                    Outsourced outSourced = new Outsourced(txtPartName.Text, Convert.ToInt32(txtPartInventory.Text), Convert.ToDecimal(txtPartPrice.Text), Convert.ToInt32(txtPartMax.Text), Convert.ToInt32(txtPartMin.Text), txtPartMachineID.Text);

                    Inventory.AddPart(outSourced);
                }

            }
            this.Close();
            this.Hide();
            mainForm.Show();
            

        }

        // to cancel the current form
        private void btnCancelPart_Click(object sender, EventArgs e)
        {
            mainForm.Show();

            this.Close();
        }

        private void PartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
