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
    public partial class ModifyPartForm : Form
    {
        MainForm mainForm = new MainForm();

        //properties - modifypartform
        private Part part;

        private bool SelectInHouse;

        
            public ModifyPartForm()
        {

            InitializeComponent();

            part = Inventory.InventoryPartSelected;

            if (part != null)
            {
                // convert to strings
                txtModifyPartID.Text = part.PartID.ToString();
                txtModifyPartName.Text = part.Name.ToString();
                txtModifyPartInventory.Text = part.Inventory.ToString();
                txtModifyPartPrice.Text = part.Price.ToString();
                txtModifyPartMax.Text = part.Max.ToString();
                txtModifyPartMin.Text = part.Min.ToString();

                //if the inhouse radiobutton is selected
                if (Inventory.InventoryPartSelected is InHouse)
                {
                    //cast part to Inhouse
                    InHouse inHouse = (InHouse)part;
                
                    txtModifyPartMachineID.Text = inHouse.MachinePartID.ToString();
                    SelectInHouse = true;
                    rbtnModifyInHouse.Checked = true;

                }
                else
                {
                    //cast part to Outsourced
                    Outsourced outsourced = (Outsourced)part;
                    txtModifyPartMachineID.Text = outsourced.Company;
                    SelectInHouse = false;
                    rbtnModifyOutsourced.Checked = true;
                }
            }

        }


        // to save inputs once validated

        private bool LetSave()
        {
            
            if (SelectInHouse)
            {
                //checks if the Machinebox - valid integer
                if (!Inventory.IsValidInt(txtModifyPartMachineID.Text))
                {
                    return false;
                }
            }
            //checks if the machinebox - valid string
            if (!Inventory.IsValidString(txtModifyPartMachineID.Text))
            {
                return false;
            }
            //checks if the namebox - valid string
            if (!Inventory.IsValidString(txtModifyPartName.Text))
            {
                return false;
            }
            //checks if the inventorybox - valid integer
            if (!Inventory.IsValidInt(txtModifyPartInventory.Text))
            {
                return false;
            }
            //checks if the pricebox - valid decimal

            if (!Inventory.IsValidDecimal(txtModifyPartPrice.Text))
            {
                return false;
            }
            //checks if the maxbox - valid integer

            if (!Inventory.IsValidInt(txtModifyPartMax.Text))
            {
                return false;
            }
            //checks if the minbox - valid integer

            if (!Inventory.IsValidInt(txtModifyPartMin.Text))
            {
                return false;
            }
            //checks if the invetory, max, and min - valid range
            //
            if (!Inventory.ValidMinMax(txtModifyPartInventory.Text, txtModifyPartMax.Text, txtModifyPartMin.Text))
            {
                return false;
            }
            return true;
        }
        //Inhouse selected
        //run the validations
        //allow to be saved
        private void rbtnModifyInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Machine ID";
            SelectInHouse = true;
            bool isValidMachineID = Inventory.IsValidInt(txtModifyPartMachineID.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //Outsourced selected
        //run the validations
        //allow to be saved
        private void rbtnModifyOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineID.Text = "Company Name";
            SelectInHouse = false;
            bool isValidCompany = Inventory.IsValidString(txtModifyPartMachineID.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part name box selected
        //run the validations
        //allow to be saved
        private void txtModifyPartName_TextChanged(object sender, EventArgs e)
        {
            bool isValidName = Inventory.IsValidString(txtModifyPartName.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part inventory box selected
        //run the validations
        //allow to be saved
        private void txtModifyPartInventory_TextChanged(object sender, EventArgs e)
        {
            bool isValidInventory = Inventory.IsValidInt(txtModifyPartInventory.Text) &&
            Inventory.ValidMinMax(txtModifyPartInventory.Text, txtModifyPartMax.Text, txtModifyPartMin.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part price selected
        //run the validations
        //allow to be saved
        private void txtModifyPartPrice_TextChanged(object sender, EventArgs e)
        {
            bool isValidPrice = Inventory.IsValidDecimal(txtModifyPartPrice.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part max selected
        //run the validations
        //allow to be saved
        private void txtModifyPartMax_TextChanged(object sender, EventArgs e)
        {
            bool isValidMax = Inventory.ValidMinMax(txtModifyPartInventory.Text, txtModifyPartMax.Text, txtModifyPartMin.Text) &&
            Inventory.IsValidInt(txtModifyPartMax.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part min selected
        //run the validations
        //allow to be saved
        private void txtModifyPartMin_TextChanged(object sender, EventArgs e)
        {
            bool isValidMin = Inventory.ValidMinMax(txtModifyPartInventory.Text, txtModifyPartMax.Text, txtModifyPartMin.Text) && Inventory.IsValidInt(txtModifyPartMin.Text);
            btnModifySavePart.Enabled = LetSave();
        }

        //part machineid selected
        //run the validations
        //allow to be saved
        private void txtModifyPartMachineID_TextChanged(object sender, EventArgs e)
        {
            if (SelectInHouse)
            {
                //checks the validations -  set to int
                bool isMachineID = Inventory.IsValidInt(txtModifyPartMachineID.Text);
            }
            else
            {
                //checks the validations - set to string
                bool isCompanyName = Inventory.IsValidString(txtModifyPartMachineID.Text);
            }
            btnModifySavePart.Enabled = LetSave();
        }

        // to save inputs once validated
        private void btnModifySavePart_Click(object sender, EventArgs e)
        {
            if (part == null)
            {
                //Inhouse selected
                //run the validations
                //convert to their respective data types
                //allow to be saved
                if (SelectInHouse)
                {
                    InHouse inHouse = new InHouse(txtModifyPartName.Text, Convert.ToInt32(txtModifyPartInventory.Text), Convert.ToDecimal(txtModifyPartPrice.Text), Convert.ToInt32(txtModifyPartMax.Text), Convert.ToInt32(txtModifyPartMin.Text), Convert.ToInt32(txtModifyPartMachineID.Text));

                    Inventory.AddPart(inHouse);
                }
                //Outsourced selected
                //run the validations
                //convert to their respective data types
                //allow to be saved
                else
                {
                    Outsourced outSourced = new Outsourced(txtModifyPartName.Text, Convert.ToInt32(txtModifyPartInventory.Text), Convert.ToDecimal(txtModifyPartPrice.Text), Convert.ToInt32(txtModifyPartMax.Text), Convert.ToInt32(txtModifyPartMin.Text), txtModifyPartMachineID.Text);

                    Inventory.AddPart(outSourced);
                }
            }
            //switch the form
            else
            {
                //Inhouse selected
                //run the validations
                //convert to their respective data types
                //allow to be saved
                if (SelectInHouse)
                {
                    InHouse inHouse = new InHouse(Convert.ToInt32(txtModifyPartID.Text),txtModifyPartName.Text, Convert.ToInt32(txtModifyPartInventory.Text), Convert.ToDecimal(txtModifyPartPrice.Text), Convert.ToInt32(txtModifyPartMax.Text), Convert.ToInt32(txtModifyPartMin.Text), Convert.ToInt32(txtModifyPartMachineID.Text));

                    Inventory.PassItems(inHouse);
                }
                //Outsourced selected
                //run the validations
                //convert to their respective data types
                //allow to be saved
                else
                {
                    Outsourced outSourced = new Outsourced(Convert.ToInt32(txtModifyPartID.Text),txtModifyPartName.Text, Convert.ToInt32(txtModifyPartInventory.Text), Convert.ToDecimal(txtModifyPartPrice.Text), Convert.ToInt32(txtModifyPartMax.Text), Convert.ToInt32(txtModifyPartMin.Text), txtModifyPartMachineID.Text);

                    Inventory.PassItems(outSourced);
                }
                btnModifySavePart.Enabled = LetSave();
            }

            this.Hide();
            mainForm.Show();
        }

        // to cancel the form
        private void btnModifyCancelPart_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
        // to save inputs after validation



    }
    
}
