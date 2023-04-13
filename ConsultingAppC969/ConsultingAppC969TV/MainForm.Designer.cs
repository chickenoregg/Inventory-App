
namespace ConsultingAppC969
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet = new ConsultingAppC969.client_scheduleDataSet();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet1 = new ConsultingAppC969.client_scheduleDataSet1();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnModifyCustomer = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnModifyAppointment = new System.Windows.Forms.Button();
            this.dgvCalenders = new System.Windows.Forms.DataGridView();
            this.rbtnWeekly = new System.Windows.Forms.RadioButton();
            this.lblCalenders = new System.Windows.Forms.Label();
            this.rbtnMonthly = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.btnByMonthReport = new System.Windows.Forms.Button();
            this.btnByConsultantReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.customerTableAdapter = new ConsultingAppC969.client_scheduleDataSetTableAdapters.customerTableAdapter();
            this.appointmentTableAdapter = new ConsultingAppC969.client_scheduleDataSet1TableAdapters.appointmentTableAdapter();
            this.btnTotalAppointments = new System.Windows.Forms.Button();
            this.lblBusinessHours = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.txtSearchByDate = new System.Windows.Forms.TextBox();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeColumns = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.customerBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(16, 54);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(660, 294);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "customerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "customerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAppointments.Location = new System.Drawing.Point(769, 54);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 51;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(660, 294);
            this.dgvAppointments.TabIndex = 1;
            this.dgvAppointments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.client_scheduleDataSet1;
            // 
            // client_scheduleDataSet1
            // 
            this.client_scheduleDataSet1.DataSetName = "client_scheduleDataSet1";
            this.client_scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(12, 28);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(71, 16);
            this.lblCustomers.TabIndex = 2;
            this.lblCustomers.Text = "Customers";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Location = new System.Drawing.Point(765, 28);
            this.lblAppointments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(89, 16);
            this.lblAppointments.TabIndex = 3;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(16, 375);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnAddCustomer.TabIndex = 4;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(124, 375);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteCustomer.TabIndex = 5;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnModifyCustomer
            // 
            this.btnModifyCustomer.Location = new System.Drawing.Point(232, 375);
            this.btnModifyCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyCustomer.Name = "btnModifyCustomer";
            this.btnModifyCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnModifyCustomer.TabIndex = 6;
            this.btnModifyCustomer.Text = "Modify";
            this.btnModifyCustomer.UseVisualStyleBackColor = true;
            this.btnModifyCustomer.Click += new System.EventHandler(this.btnModifyCustomer_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Location = new System.Drawing.Point(769, 375);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnAddAppointment.TabIndex = 7;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(877, 375);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteAppointment.TabIndex = 8;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnModifyAppointment
            // 
            this.btnModifyAppointment.Location = new System.Drawing.Point(985, 375);
            this.btnModifyAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyAppointment.Name = "btnModifyAppointment";
            this.btnModifyAppointment.Size = new System.Drawing.Size(100, 28);
            this.btnModifyAppointment.TabIndex = 9;
            this.btnModifyAppointment.Text = "Modify";
            this.btnModifyAppointment.UseVisualStyleBackColor = true;
            this.btnModifyAppointment.Click += new System.EventHandler(this.btnModifyAppointment_Click);
            // 
            // dgvCalenders
            // 
            this.dgvCalenders.AllowUserToAddRows = false;
            this.dgvCalenders.AllowUserToDeleteRows = false;
            this.dgvCalenders.AllowUserToResizeColumns = false;
            this.dgvCalenders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalenders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalenders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalenders.Location = new System.Drawing.Point(769, 442);
            this.dgvCalenders.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCalenders.MultiSelect = false;
            this.dgvCalenders.Name = "dgvCalenders";
            this.dgvCalenders.ReadOnly = true;
            this.dgvCalenders.RowHeadersVisible = false;
            this.dgvCalenders.RowHeadersWidth = 51;
            this.dgvCalenders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalenders.Size = new System.Drawing.Size(660, 294);
            this.dgvCalenders.TabIndex = 11;
            // 
            // rbtnWeekly
            // 
            this.rbtnWeekly.AutoSize = true;
            this.rbtnWeekly.Location = new System.Drawing.Point(769, 758);
            this.rbtnWeekly.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWeekly.Name = "rbtnWeekly";
            this.rbtnWeekly.Size = new System.Drawing.Size(74, 20);
            this.rbtnWeekly.TabIndex = 12;
            this.rbtnWeekly.Text = "Weekly";
            this.rbtnWeekly.UseVisualStyleBackColor = true;
            this.rbtnWeekly.CheckedChanged += new System.EventHandler(this.rbtnWeekly_CheckedChanged);
            // 
            // lblCalenders
            // 
            this.lblCalenders.AutoSize = true;
            this.lblCalenders.Location = new System.Drawing.Point(765, 422);
            this.lblCalenders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalenders.Name = "lblCalenders";
            this.lblCalenders.Size = new System.Drawing.Size(69, 16);
            this.lblCalenders.TabIndex = 14;
            this.lblCalenders.Text = "Calendars";
            // 
            // rbtnMonthly
            // 
            this.rbtnMonthly.AutoSize = true;
            this.rbtnMonthly.Location = new System.Drawing.Point(859, 758);
            this.rbtnMonthly.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMonthly.Name = "rbtnMonthly";
            this.rbtnMonthly.Size = new System.Drawing.Size(74, 20);
            this.rbtnMonthly.TabIndex = 15;
            this.rbtnMonthly.Text = "Monthly";
            this.rbtnMonthly.UseVisualStyleBackColor = true;
            this.rbtnMonthly.CheckedChanged += new System.EventHandler(this.rbtnMonthly_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(949, 758);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(43, 20);
            this.rbtnAll.TabIndex = 16;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // btnByMonthReport
            // 
            this.btnByMonthReport.Location = new System.Drawing.Point(16, 506);
            this.btnByMonthReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnByMonthReport.Name = "btnByMonthReport";
            this.btnByMonthReport.Size = new System.Drawing.Size(660, 28);
            this.btnByMonthReport.TabIndex = 17;
            this.btnByMonthReport.Text = "Month Report";
            this.btnByMonthReport.UseVisualStyleBackColor = true;
            this.btnByMonthReport.Click += new System.EventHandler(this.btnByMonthReport_Click);
            // 
            // btnByConsultantReport
            // 
            this.btnByConsultantReport.Location = new System.Drawing.Point(16, 607);
            this.btnByConsultantReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnByConsultantReport.Name = "btnByConsultantReport";
            this.btnByConsultantReport.Size = new System.Drawing.Size(660, 28);
            this.btnByConsultantReport.TabIndex = 18;
            this.btnByConsultantReport.Text = "Consultant Report";
            this.btnByConsultantReport.UseVisualStyleBackColor = true;
            this.btnByConsultantReport.Click += new System.EventHandler(this.btnByConsultantReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1329, 743);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // btnTotalAppointments
            // 
            this.btnTotalAppointments.Location = new System.Drawing.Point(16, 694);
            this.btnTotalAppointments.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalAppointments.Name = "btnTotalAppointments";
            this.btnTotalAppointments.Size = new System.Drawing.Size(660, 28);
            this.btnTotalAppointments.TabIndex = 19;
            this.btnTotalAppointments.Text = "Appointment Total Report";
            this.btnTotalAppointments.UseVisualStyleBackColor = true;
            this.btnTotalAppointments.Click += new System.EventHandler(this.btnTotalAppointments_Click);
            // 
            // lblBusinessHours
            // 
            this.lblBusinessHours.AutoSize = true;
            this.lblBusinessHours.Location = new System.Drawing.Point(945, 28);
            this.lblBusinessHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBusinessHours.Name = "lblBusinessHours";
            this.lblBusinessHours.Size = new System.Drawing.Size(179, 16);
            this.lblBusinessHours.TabIndex = 21;
            this.lblBusinessHours.Text = "Business Hours: 06:00 - 16:00";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(296, 442);
            this.lblReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(98, 29);
            this.lblReports.TabIndex = 22;
            this.lblReports.Text = "Reports";
            // 
            // txtSearchByDate
            // 
            this.txtSearchByDate.Location = new System.Drawing.Point(1164, 25);
            this.txtSearchByDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchByDate.Name = "txtSearchByDate";
            this.txtSearchByDate.Size = new System.Drawing.Size(132, 22);
            this.txtSearchByDate.TabIndex = 23;
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(1305, 22);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(124, 28);
            this.btnSearchByDate.TabIndex = 24;
            this.btnSearchByDate.Text = "Search By Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 794);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.txtSearchByDate);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblBusinessHours);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotalAppointments);
            this.Controls.Add(this.btnByConsultantReport);
            this.Controls.Add(this.btnByMonthReport);
            this.Controls.Add(this.rbtnAll);
            this.Controls.Add(this.rbtnMonthly);
            this.Controls.Add(this.lblCalenders);
            this.Controls.Add(this.rbtnWeekly);
            this.Controls.Add(this.dgvCalenders);
            this.Controls.Add(this.btnModifyAppointment);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnModifyCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.dgvCustomers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalenders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnModifyCustomer;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnModifyAppointment;
        private System.Windows.Forms.DataGridView dgvCalenders;
        private System.Windows.Forms.RadioButton rbtnWeekly;
        private System.Windows.Forms.Label lblCalenders;
        private System.Windows.Forms.RadioButton rbtnMonthly;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.Button btnByMonthReport;
        private System.Windows.Forms.Button btnByConsultantReport;
        private System.Windows.Forms.Button btnExit;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private client_scheduleDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private client_scheduleDataSet1 client_scheduleDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private client_scheduleDataSet1TableAdapters.appointmentTableAdapter appointmentTableAdapter;
        public System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnTotalAppointments;
        private System.Windows.Forms.Label lblBusinessHours;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearchByDate;
        private System.Windows.Forms.Button btnSearchByDate;
    }
}