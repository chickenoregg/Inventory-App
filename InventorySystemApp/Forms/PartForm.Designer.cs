namespace InventorySystemApp.Forms
{
    partial class PartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnInHouse = new System.Windows.Forms.RadioButton();
            this.rbtnOutsourced = new System.Windows.Forms.RadioButton();
            this.lblPartID = new System.Windows.Forms.Label();
            this.lblPartName = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblPartPrice = new System.Windows.Forms.Label();
            this.lblPartMax = new System.Windows.Forms.Label();
            this.lblPartMin = new System.Windows.Forms.Label();
            this.lblMachineID = new System.Windows.Forms.Label();
            this.txtPartID = new System.Windows.Forms.TextBox();
            this.txtPartName = new System.Windows.Forms.TextBox();
            this.txtPartInventory = new System.Windows.Forms.TextBox();
            this.txtPartPrice = new System.Windows.Forms.TextBox();
            this.txtPartMax = new System.Windows.Forms.TextBox();
            this.txtPartMin = new System.Windows.Forms.TextBox();
            this.txtPartMachineID = new System.Windows.Forms.TextBox();
            this.btnSavePart = new System.Windows.Forms.Button();
            this.btnCancelPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // rbtnInHouse
            // 
            this.rbtnInHouse.AutoSize = true;
            this.rbtnInHouse.Location = new System.Drawing.Point(191, 29);
            this.rbtnInHouse.Name = "rbtnInHouse";
            this.rbtnInHouse.Size = new System.Drawing.Size(82, 20);
            this.rbtnInHouse.TabIndex = 1;
            this.rbtnInHouse.TabStop = true;
            this.rbtnInHouse.Text = "In-House";
            this.rbtnInHouse.UseVisualStyleBackColor = true;
            this.rbtnInHouse.CheckedChanged += new System.EventHandler(this.rbtnInHouse_CheckedChanged);
            // 
            // rbtnOutsourced
            // 
            this.rbtnOutsourced.AutoSize = true;
            this.rbtnOutsourced.Location = new System.Drawing.Point(378, 29);
            this.rbtnOutsourced.Name = "rbtnOutsourced";
            this.rbtnOutsourced.Size = new System.Drawing.Size(97, 20);
            this.rbtnOutsourced.TabIndex = 2;
            this.rbtnOutsourced.Text = "Outsourced";
            this.rbtnOutsourced.UseVisualStyleBackColor = true;
            this.rbtnOutsourced.CheckedChanged += new System.EventHandler(this.rbtnOutsourced_CheckedChanged);
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Location = new System.Drawing.Point(165, 104);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(20, 16);
            this.lblPartID.TabIndex = 2;
            this.lblPartID.Text = "ID";
            // 
            // lblPartName
            // 
            this.lblPartName.AutoSize = true;
            this.lblPartName.Location = new System.Drawing.Point(165, 142);
            this.lblPartName.Name = "lblPartName";
            this.lblPartName.Size = new System.Drawing.Size(44, 16);
            this.lblPartName.TabIndex = 2;
            this.lblPartName.Text = "Name";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(165, 184);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(61, 16);
            this.lblInventory.TabIndex = 2;
            this.lblInventory.Text = "Inventory";
            // 
            // lblPartPrice
            // 
            this.lblPartPrice.AutoSize = true;
            this.lblPartPrice.Location = new System.Drawing.Point(165, 227);
            this.lblPartPrice.Name = "lblPartPrice";
            this.lblPartPrice.Size = new System.Drawing.Size(68, 16);
            this.lblPartPrice.TabIndex = 2;
            this.lblPartPrice.Text = "Part / Cost";
            // 
            // lblPartMax
            // 
            this.lblPartMax.AutoSize = true;
            this.lblPartMax.Location = new System.Drawing.Point(165, 277);
            this.lblPartMax.Name = "lblPartMax";
            this.lblPartMax.Size = new System.Drawing.Size(32, 16);
            this.lblPartMax.TabIndex = 2;
            this.lblPartMax.Text = "Max";
            // 
            // lblPartMin
            // 
            this.lblPartMin.AutoSize = true;
            this.lblPartMin.Location = new System.Drawing.Point(362, 283);
            this.lblPartMin.Name = "lblPartMin";
            this.lblPartMin.Size = new System.Drawing.Size(28, 16);
            this.lblPartMin.TabIndex = 2;
            this.lblPartMin.Text = "Min";
            // 
            // lblMachineID
            // 
            this.lblMachineID.AutoSize = true;
            this.lblMachineID.Location = new System.Drawing.Point(165, 327);
            this.lblMachineID.Name = "lblMachineID";
            this.lblMachineID.Size = new System.Drawing.Size(74, 16);
            this.lblMachineID.TabIndex = 2;
            this.lblMachineID.Text = "Machine ID";
            // 
            // txtPartID
            // 
            this.txtPartID.Location = new System.Drawing.Point(323, 104);
            this.txtPartID.Name = "txtPartID";
            this.txtPartID.ReadOnly = true;
            this.txtPartID.Size = new System.Drawing.Size(100, 22);
            this.txtPartID.TabIndex = 3;
            // 
            // txtPartName
            // 
            this.txtPartName.Location = new System.Drawing.Point(323, 136);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.Size = new System.Drawing.Size(100, 22);
            this.txtPartName.TabIndex = 4;
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // txtPartInventory
            // 
            this.txtPartInventory.Location = new System.Drawing.Point(323, 178);
            this.txtPartInventory.Name = "txtPartInventory";
            this.txtPartInventory.Size = new System.Drawing.Size(100, 22);
            this.txtPartInventory.TabIndex = 5;
            this.txtPartInventory.TextChanged += new System.EventHandler(this.txtPartInventory_TextChanged);
            // 
            // txtPartPrice
            // 
            this.txtPartPrice.Location = new System.Drawing.Point(324, 221);
            this.txtPartPrice.Name = "txtPartPrice";
            this.txtPartPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPartPrice.TabIndex = 6;
            this.txtPartPrice.TextChanged += new System.EventHandler(this.txtPartPrice_TextChanged);
            // 
            // txtPartMax
            // 
            this.txtPartMax.Location = new System.Drawing.Point(227, 277);
            this.txtPartMax.Name = "txtPartMax";
            this.txtPartMax.Size = new System.Drawing.Size(100, 22);
            this.txtPartMax.TabIndex = 8;
            this.txtPartMax.TextChanged += new System.EventHandler(this.txtPartMax_TextChanged);
            // 
            // txtPartMin
            // 
            this.txtPartMin.Location = new System.Drawing.Point(429, 280);
            this.txtPartMin.Name = "txtPartMin";
            this.txtPartMin.Size = new System.Drawing.Size(100, 22);
            this.txtPartMin.TabIndex = 7;
            this.txtPartMin.TextChanged += new System.EventHandler(this.txtPartMin_TextChanged);
            // 
            // txtPartMachineID
            // 
            this.txtPartMachineID.Location = new System.Drawing.Point(246, 327);
            this.txtPartMachineID.Name = "txtPartMachineID";
            this.txtPartMachineID.Size = new System.Drawing.Size(100, 22);
            this.txtPartMachineID.TabIndex = 9;
            this.txtPartMachineID.TextChanged += new System.EventHandler(this.txtPartMachineID_TextChanged);
            // 
            // btnSavePart
            // 
            this.btnSavePart.Location = new System.Drawing.Point(429, 384);
            this.btnSavePart.Name = "btnSavePart";
            this.btnSavePart.Size = new System.Drawing.Size(75, 23);
            this.btnSavePart.TabIndex = 10;
            this.btnSavePart.Text = "Save";
            this.btnSavePart.UseVisualStyleBackColor = true;
            this.btnSavePart.Click += new System.EventHandler(this.btnSavePart_Click);
            // 
            // btnCancelPart
            // 
            this.btnCancelPart.Location = new System.Drawing.Point(527, 384);
            this.btnCancelPart.Name = "btnCancelPart";
            this.btnCancelPart.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPart.TabIndex = 11;
            this.btnCancelPart.Text = "Cancel";
            this.btnCancelPart.UseVisualStyleBackColor = true;
            this.btnCancelPart.Click += new System.EventHandler(this.btnCancelPart_Click);
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelPart);
            this.Controls.Add(this.btnSavePart);
            this.Controls.Add(this.txtPartMachineID);
            this.Controls.Add(this.txtPartMin);
            this.Controls.Add(this.txtPartMax);
            this.Controls.Add(this.txtPartPrice);
            this.Controls.Add(this.txtPartInventory);
            this.Controls.Add(this.txtPartName);
            this.Controls.Add(this.txtPartID);
            this.Controls.Add(this.lblPartMin);
            this.Controls.Add(this.lblPartMax);
            this.Controls.Add(this.lblMachineID);
            this.Controls.Add(this.lblPartPrice);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.lblPartName);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.rbtnOutsourced);
            this.Controls.Add(this.rbtnInHouse);
            this.Controls.Add(this.label1);
            this.Name = "PartForm";
            this.Text = "Part Form";
            this.Load += new System.EventHandler(this.PartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnInHouse;
        private System.Windows.Forms.RadioButton rbtnOutsourced;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label lblPartName;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblPartPrice;
        private System.Windows.Forms.Label lblPartMax;
        private System.Windows.Forms.Label lblPartMin;
        private System.Windows.Forms.Label lblMachineID;
        private System.Windows.Forms.TextBox txtPartID;
        private System.Windows.Forms.TextBox txtPartName;
        private System.Windows.Forms.TextBox txtPartInventory;
        private System.Windows.Forms.TextBox txtPartPrice;
        private System.Windows.Forms.TextBox txtPartMax;
        private System.Windows.Forms.TextBox txtPartMin;
        private System.Windows.Forms.TextBox txtPartMachineID;
        private System.Windows.Forms.Button btnSavePart;
        private System.Windows.Forms.Button btnCancelPart;
    }
}