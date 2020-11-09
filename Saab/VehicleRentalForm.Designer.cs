namespace Saab
{
    partial class VehicleRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleRentalForm));
            this.vehicleDatabaseDataSet1 = new Saab.VehicleDatabaseDataSet1();
            this.registerRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerRentalTableAdapter = new Saab.VehicleDatabaseDataSet1TableAdapters.RegisterRentalTableAdapter();
            this.tableAdapterManager = new Saab.VehicleDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.registerReturnTableAdapter = new Saab.VehicleDatabaseDataSet1TableAdapters.RegisterReturnTableAdapter();
            this.registerRentalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registerRentalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registerRentalDataGridView = new System.Windows.Forms.DataGridView();
            this.RentBookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentPersonalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentVehicleCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentCurrentDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleDatabaseDataSetCost = new Saab.VehicleDatabaseDataSetCost();
            this.registerReturnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerReturnTableAdapter1 = new Saab.VehicleDatabaseDataSetCostTableAdapters.RegisterReturnTableAdapter();
            this.tableAdapterManager1 = new Saab.VehicleDatabaseDataSetCostTableAdapters.TableAdapterManager();
            this.registerReturnDataGridView = new System.Windows.Forms.DataGridView();
            this.BookingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingNavigator)).BeginInit();
            this.registerRentalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSetCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleDatabaseDataSet1
            // 
            this.vehicleDatabaseDataSet1.DataSetName = "VehicleDatabaseDataSet1";
            this.vehicleDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerRentalBindingSource
            // 
            this.registerRentalBindingSource.DataMember = "RegisterRental";
            this.registerRentalBindingSource.DataSource = this.vehicleDatabaseDataSet1;
            // 
            // registerRentalTableAdapter
            // 
            this.registerRentalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.RegisterRentalTableAdapter = this.registerRentalTableAdapter;
            this.tableAdapterManager.RegisterReturnTableAdapter = this.registerReturnTableAdapter;
            this.tableAdapterManager.UpdateOrder = Saab.VehicleDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registerReturnTableAdapter
            // 
            this.registerReturnTableAdapter.ClearBeforeFill = true;
            // 
            // registerRentalBindingNavigator
            // 
            this.registerRentalBindingNavigator.AddNewItem = null;
            this.registerRentalBindingNavigator.BindingSource = this.registerRentalBindingSource;
            this.registerRentalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registerRentalBindingNavigator.DeleteItem = null;
            this.registerRentalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.registerRentalBindingNavigatorSaveItem});
            this.registerRentalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registerRentalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registerRentalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registerRentalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registerRentalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registerRentalBindingNavigator.Name = "registerRentalBindingNavigator";
            this.registerRentalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registerRentalBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.registerRentalBindingNavigator.TabIndex = 0;
            this.registerRentalBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // registerRentalBindingNavigatorSaveItem
            // 
            this.registerRentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registerRentalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registerRentalBindingNavigatorSaveItem.Image")));
            this.registerRentalBindingNavigatorSaveItem.Name = "registerRentalBindingNavigatorSaveItem";
            this.registerRentalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.registerRentalBindingNavigatorSaveItem.Text = "Save Data";
            this.registerRentalBindingNavigatorSaveItem.Click += new System.EventHandler(this.registerRentalBindingNavigatorSaveItem_Click);
            // 
            // registerRentalDataGridView
            // 
            this.registerRentalDataGridView.AllowUserToDeleteRows = false;
            this.registerRentalDataGridView.AutoGenerateColumns = false;
            this.registerRentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerRentalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentBookingNumber,
            this.RentPersonalNumber,
            this.RentVehicleCategory,
            this.RentDate,
            this.RentTime,
            this.RentCurrentDistance});
            this.registerRentalDataGridView.DataSource = this.registerRentalBindingSource;
            this.registerRentalDataGridView.Location = new System.Drawing.Point(12, 28);
            this.registerRentalDataGridView.Name = "registerRentalDataGridView";
            this.registerRentalDataGridView.Size = new System.Drawing.Size(643, 220);
            this.registerRentalDataGridView.TabIndex = 1;
            // 
            // RentBookingNumber
            // 
            this.RentBookingNumber.DataPropertyName = "Booking Number";
            this.RentBookingNumber.HeaderText = "Booking Number";
            this.RentBookingNumber.Name = "RentBookingNumber";
            // 
            // RentPersonalNumber
            // 
            this.RentPersonalNumber.DataPropertyName = "Personal Number";
            this.RentPersonalNumber.HeaderText = "Personal Security Number";
            this.RentPersonalNumber.Name = "RentPersonalNumber";
            // 
            // RentVehicleCategory
            // 
            this.RentVehicleCategory.DataPropertyName = "Vehicle Category";
            this.RentVehicleCategory.HeaderText = "Vehicle Category";
            this.RentVehicleCategory.Name = "RentVehicleCategory";
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "Date";
            this.RentDate.HeaderText = "Date";
            this.RentDate.Name = "RentDate";
            // 
            // RentTime
            // 
            this.RentTime.DataPropertyName = "Time";
            this.RentTime.HeaderText = "Time";
            this.RentTime.Name = "RentTime";
            // 
            // RentCurrentDistance
            // 
            this.RentCurrentDistance.DataPropertyName = "Current Distance";
            this.RentCurrentDistance.HeaderText = "Current Distance";
            this.RentCurrentDistance.Name = "RentCurrentDistance";
            // 
            // registerReturnBindingSource
            // 
            this.registerReturnBindingSource.DataMember = "RegisterReturn";
            this.registerReturnBindingSource.DataSource = this.vehicleDatabaseDataSet1;
            // 
            // vehicleDatabaseDataSetCost
            // 
            this.vehicleDatabaseDataSetCost.DataSetName = "VehicleDatabaseDataSetCost";
            this.vehicleDatabaseDataSetCost.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerReturnBindingSource1
            // 
            this.registerReturnBindingSource1.DataMember = "RegisterReturn";
            this.registerReturnBindingSource1.DataSource = this.vehicleDatabaseDataSetCost;
            // 
            // registerReturnTableAdapter1
            // 
            this.registerReturnTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.RegisterReturnTableAdapter = this.registerReturnTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Saab.VehicleDatabaseDataSetCostTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registerReturnDataGridView
            // 
            this.registerReturnDataGridView.AllowUserToDeleteRows = false;
            this.registerReturnDataGridView.AutoGenerateColumns = false;
            this.registerReturnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerReturnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookingNumber,
            this.Date,
            this.Time,
            this.CurrentDistance,
            this.Calculate,
            this.TotalCost});
            this.registerReturnDataGridView.DataSource = this.registerReturnBindingSource1;
            this.registerReturnDataGridView.Location = new System.Drawing.Point(12, 281);
            this.registerReturnDataGridView.Name = "registerReturnDataGridView";
            this.registerReturnDataGridView.Size = new System.Drawing.Size(643, 220);
            this.registerReturnDataGridView.TabIndex = 22;
            this.registerReturnDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerReturnDataGridView_CellContentClick_1);
            // 
            // BookingNumber
            // 
            this.BookingNumber.DataPropertyName = "Booking Number";
            this.BookingNumber.HeaderText = "Booking Number";
            this.BookingNumber.Name = "BookingNumber";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // CurrentDistance
            // 
            this.CurrentDistance.DataPropertyName = "Current Distance";
            this.CurrentDistance.HeaderText = "Current Distance";
            this.CurrentDistance.Name = "CurrentDistance";
            // 
            // Calculate
            // 
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Calculate.HeaderText = "Calculate Total Cost";
            this.Calculate.Name = "Calculate";
            this.Calculate.Text = "Calculate";
            this.Calculate.UseColumnTextForButtonValue = true;
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "Total Cost";
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // VehicleRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 518);
            this.Controls.Add(this.registerReturnDataGridView);
            this.Controls.Add(this.registerRentalDataGridView);
            this.Controls.Add(this.registerRentalBindingNavigator);
            this.Name = "VehicleRentalForm";
            this.Text = "Vehicle Rental Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingNavigator)).EndInit();
            this.registerRentalBindingNavigator.ResumeLayout(false);
            this.registerRentalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSetCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VehicleDatabaseDataSet1 vehicleDatabaseDataSet1;
        private System.Windows.Forms.BindingSource registerRentalBindingSource;
        private VehicleDatabaseDataSet1TableAdapters.RegisterRentalTableAdapter registerRentalTableAdapter;
        private VehicleDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registerRentalBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton registerRentalBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registerRentalDataGridView;
        private VehicleDatabaseDataSet1TableAdapters.RegisterReturnTableAdapter registerReturnTableAdapter;
        private System.Windows.Forms.BindingSource registerReturnBindingSource;
        private VehicleDatabaseDataSetCost vehicleDatabaseDataSetCost;
        private System.Windows.Forms.BindingSource registerReturnBindingSource1;
        private VehicleDatabaseDataSetCostTableAdapters.RegisterReturnTableAdapter registerReturnTableAdapter1;
        private VehicleDatabaseDataSetCostTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView registerReturnDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentBookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentPersonalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentVehicleCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentCurrentDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDistance;
        private System.Windows.Forms.DataGridViewButtonColumn Calculate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}

