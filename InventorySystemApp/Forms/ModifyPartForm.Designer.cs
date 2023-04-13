namespace InventorySystemApp.Forms
{
    partial class ModifyPartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModifyCancelPart = new System.Windows.Forms.Button();
            this.btnModifySavePart = new System.Windows.Forms.Button();
            this.txtModifyPartMachineID = new System.Windows.Forms.TextBox();
            this.txtModifyPartMin = new System.Windows.Forms.TextBox();
            this.txtModifyPartMax = new System.Windows.Forms.TextBox();
            this.txtModifyPartPrice = new System.Windows.Forms.TextBox();
            this.txtModifyPartInventory = new System.Windows.Forms.TextBox();
            this.txtModifyPartName = new System.Windows.Forms.TextBox();
            this.txtModifyPartID = new System.Windows.Forms.TextBox();
            this.lblPartMin = new System.Windows.Forms.Label();
            this.lblPartMax = new System.Windows.Forms.Label();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.lblPartPrice = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblPartID = new System.Windows.Forms.Label();
            this.rbtnModifyOutsourced = new System.Windows.Forms.RadioButton();
            this.rbtnModifyInHouse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifyCancelPart
            // 
            this.btnModifyCancelPart.Location = new System.Drawing.Point(544, 391);
            this.btnModifyCancelPart.Name = "btnModifyCancelPart";
            this.btnModifyCancelPart.Size = new System.Drawing.Size(75, 23);
            this.btnModifyCancelPart.TabIndex = 22;
            this.btnModifyCancelPart.Text = "Cancel";
            this.btnModifyCancelPart.UseVisualStyleBackColor = true;
            this.btnModifyCancelPart.Click += new System.EventHandler(this.btnModifyCancelPart_Click);
            // 
            // btnModifySavePart
            // 
            this.btnModifySavePart.Location = new System.Drawing.Point(446, 391);
            this.btnModifySavePart.Name = "btnModifySavePart";
            this.btnModifySavePart.Size = new System.Drawing.Size(75, 23);
            this.btnModifySavePart.TabIndex = 21;
            this.btnModifySavePart.Text = "Save";
            this.btnModifySavePart.UseVisualStyleBackColor = true;
            this.btnModifySavePart.Click += new System.EventHandler(this.btnModifySavePart_Click);
            // 
            // txtModifyPartMachineID
            // 
            this.txtModifyPartMachineID.Location = new System.Drawing.Point(283, 334);
            this.txtModifyPartMachineID.Name = "txtModifyPartMachineID";
            this.txtModifyPartMachineID.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartMachineID.TabIndex = 19;
            this.txtModifyPartMachineID.TextChanged += new System.EventHandler(this.txtModifyPartMachineID_TextChanged);
            // 
            // txtModifyPartMin
            // 
            this.txtModifyPartMin.Location = new System.Drawing.Point(446, 287);
            this.txtModifyPartMin.Name = "txtModifyPartMin";
            this.txtModifyPartMin.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartMin.TabIndex = 18;
            this.txtModifyPartMin.TextChanged += new System.EventHandler(this.txtModifyPartMin_TextChanged);
            // 
            // txtModifyPartMax
            // 
            this.txtModifyPartMax.Location = new System.Drawing.Point(244, 284);
            this.txtModifyPartMax.Name = "txtModifyPartMax";
            this.txtModifyPartMax.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartMax.TabIndex = 17;
            this.txtModifyPartMax.TextChanged += new System.EventHandler(this.txtModifyPartMax_TextChanged);
            // 
            // txtModifyPartPrice
            // 
            this.txtModifyPartPrice.Location = new System.Drawing.Point(340, 228);
            this.txtModifyPartPrice.Name = "txtModifyPartPrice";
            this.txtModifyPartPrice.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartPrice.TabIndex = 16;
            this.txtModifyPartPrice.TextChanged += new System.EventHandler(this.txtModifyPartPrice_TextChanged);
            // 
            // txtModifyPartInventory
            // 
            this.txtModifyPartInventory.Location = new System.Drawing.Point(340, 185);
            this.txtModifyPartInventory.Name = "txtModifyPartInventory";
            this.txtModifyPartInventory.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartInventory.TabIndex = 15;
            this.txtModifyPartInventory.TextChanged += new System.EventHandler(this.txtModifyPartInventory_TextChanged);
            // 
            // txtModifyPartName
            // 
            this.txtModifyPartName.Location = new System.Drawing.Point(340, 143);
            this.txtModifyPartName.Name = "txtModifyPartName";
            this.txtModifyPartName.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartName.TabIndex = 20;
            this.txtModifyPartName.TextChanged += new System.EventHandler(this.txtModifyPartName_TextChanged);
            // 
            // txtModifyPartID
            // 
            this.txtModifyPartID.Location = new System.Drawing.Point(340, 111);
            this.txtModifyPartID.Name = "txtModifyPartID";
            this.txtModifyPartID.ReadOnly = true;
            this.txtModifyPartID.Size = new System.Drawing.Size(100, 22);
            this.txtModifyPartID.TabIndex = 14;
            // 
            // lblPartMin
            // 
            this.lblPartMin.AutoSize = true;
            this.lblPartMin.Location = new System.Drawing.Point(379, 290);
            this.lblPartMin.Name = "lblPartMin";
            this.lblPartMin.Size = new System.Drawing.Size(28, 16);
            this.lblPartMin.TabIndex = 13;
            this.lblPartMin.Text = "Min";
            // 
            // lblPartMax
            // 
            this.lblPartMax.AutoSize = true;
            this.lblPartMax.Location = new System.Drawing.Point(182, 284);
            this.lblPartMax.Name = "lblPartMax";
            this.lblPartMax.Size = new System.Drawing.Size(32, 16);
            this.lblPartMax.TabIndex = 12;
            this.lblPartMax.Text = "Max";
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(182, 334);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(74, 16);
            this.lblMachineID.TabIndex = 11;
            this.lblMachineID.Text = "Machine ID";
            // 
            // lblPartPrice
            // 
            this.lblPartPrice.AutoSize = true;
            this.lblPartPrice.Location = new System.Drawing.Point(182, 234);
            this.lblPartPrice.Name = "lblPartPrice";
            this.lblPartPrice.Size = new System.Drawing.Size(68, 16);
            this.lblPartPrice.TabIndex = 10;
            this.lblPartPrice.Text = "Part / Cost";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(182, 191);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 16);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(182, 149);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(44, 16);
            this.lblPartName.TabIndex = 8;
            this.lblPartName.Text = "Name";
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Location = new System.Drawing.Point(182, 111);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(20, 16);
            this.lblPartID.TabIndex = 7;
            this.lblPartID.Text = "ID";
            // 
            // rbtnModifyOutsourced
            // 
            this.rbtnModifyOutsourced.AutoSize = true;
            this.rbtnModifyOutsourced.Location = new System.Drawing.Point(395, 36);
            this.rbtnModifyOutsourced.Name = "rbtnModifyOutsourced";
            this.rbtnModifyOutsourced.Size = new System.Drawing.Size(97, 20);
            this.rbtnModifyOutsourced.TabIndex = 6;
            this.rbtnModifyOutsourced.TabStop = true;
            this.rbtnModifyOutsourced.Text = "Outsourced";
            this.rbtnModifyOutsourced.UseVisualStyleBackColor = true;
            this.rbtnModifyOutsourced.CheckedChanged += new System.EventHandler(this.rbtnModifyOutsourced_CheckedChanged);
            // 
            // rbtnModifyInHouse
            // 
            this.rbtnModifyInHouse.AutoSize = true;
            this.rbtnModifyInHouse.Location = new System.Drawing.Point(208, 36);
            this.rbtnModifyInHouse.Name = "rbtnModifyInHouse";
            this.rbtnModifyInHouse.Size = new System.Drawing.Size(82, 20);
            this.rbtnModifyInHouse.TabIndex = 5;
            this.rbtnModifyInHouse.TabStop = true;
            this.rbtnModifyInHouse.Text = "In-House";
            this.rbtnModifyInHouse.UseVisualStyleBackColor = true;
            this.rbtnModifyInHouse.CheckedChanged += new System.EventHandler(this.rbtnModifyInHouse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Modify Part";
            // 
            // ModifyPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModifyCancelPart);
            this.Controls.Add(this.btnModifySavePart);
            this.Controls.Add(this.txtModifyPartMachineID);
            this.Controls.Add(this.txtModifyPartMin);
            this.Controls.Add(this.txtModifyPartMax);
            this.Controls.Add(this.txtModifyPartPrice);
            this.Controls.Add(this.txtModifyPartInventory);
            this.Controls.Add(this.txtModifyPartName);
            this.Controls.Add(this.txtModifyPartID);
            this.Controls.Add(this.lblPartMin);
            this.Controls.Add(this.lblPartMax);
            this.Controls.Add(this.lblMachineID);
            this.Controls.Add(this.lblPartPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.rbtnModifyOutsourced);
            this.Controls.Add(this.rbtnModifyInHouse);
            this.Name = "ModifyPartForm";
            this.Text = "Modify Part Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyCancelPart;
        private System.Windows.Forms.Button btnModifySavePart;
        private System.Windows.Forms.TextBox txtModifyPartMachineID;
        private System.Windows.Forms.TextBox txtModifyPartMin;
        private System.Windows.Forms.TextBox txtModifyPartMax;
        private System.Windows.Forms.TextBox txtModifyPartPrice;
        private System.Windows.Forms.TextBox txtModifyPartInventory;
        private System.Windows.Forms.TextBox txtModifyPartName;
        private System.Windows.Forms.TextBox txtModifyPartID;
        private System.Windows.Forms.Label lblPartMin;
        private System.Windows.Forms.Label lblPartMax;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.RadioButton rbtnModifyOutsourced;
        private System.Windows.Forms.RadioButton rbtnModifyInHouse;
        private System.Windows.Forms.Label label1;
    }
}