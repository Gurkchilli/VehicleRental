namespace Saab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label booking_NumberLabel;
            System.Windows.Forms.Label personal_NumberLabel;
            System.Windows.Forms.Label vehicle_CategoryLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label current_DistanceLabel;
            System.Windows.Forms.Label booking_NumberLabel1;
            System.Windows.Forms.Label dateLabel1;
            System.Windows.Forms.Label timeLabel1;
            System.Windows.Forms.Label current_DistanceLabel1;
            this.vehicleDatabaseDataSet1 = new Saab.VehicleDatabaseDataSet1();
            this.registerRentalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerRentalTableAdapter = new Saab.VehicleDatabaseDataSet1TableAdapters.RegisterRentalTableAdapter();
            this.tableAdapterManager = new Saab.VehicleDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.registerRentalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registerRentalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registerRentalDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerReturnTableAdapter = new Saab.VehicleDatabaseDataSet1TableAdapters.RegisterReturnTableAdapter();
            this.booking_NumberTextBox = new System.Windows.Forms.TextBox();
            this.personal_NumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_CategoryTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.current_DistanceTextBox = new System.Windows.Forms.TextBox();
            this.registerReturnDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booking_NumberTextBox1 = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox1 = new System.Windows.Forms.TextBox();
            this.current_DistanceTextBox1 = new System.Windows.Forms.TextBox();
            booking_NumberLabel = new System.Windows.Forms.Label();
            personal_NumberLabel = new System.Windows.Forms.Label();
            vehicle_CategoryLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            current_DistanceLabel = new System.Windows.Forms.Label();
            booking_NumberLabel1 = new System.Windows.Forms.Label();
            dateLabel1 = new System.Windows.Forms.Label();
            timeLabel1 = new System.Windows.Forms.Label();
            current_DistanceLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingNavigator)).BeginInit();
            this.registerRentalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource)).BeginInit();
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
            // registerRentalBindingNavigator
            // 
            this.registerRentalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registerRentalBindingNavigator.BindingSource = this.registerRentalBindingSource;
            this.registerRentalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registerRentalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.registerRentalBindingNavigatorSaveItem});
            this.registerRentalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registerRentalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registerRentalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registerRentalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registerRentalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registerRentalBindingNavigator.Name = "registerRentalBindingNavigator";
            this.registerRentalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registerRentalBindingNavigator.Size = new System.Drawing.Size(1030, 25);
            this.registerRentalBindingNavigator.TabIndex = 0;
            this.registerRentalBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // registerRentalBindingNavigatorSaveItem
            // 
            this.registerRentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registerRentalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registerRentalBindingNavigatorSaveItem.Image")));
            this.registerRentalBindingNavigatorSaveItem.Name = "registerRentalBindingNavigatorSaveItem";
            this.registerRentalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.registerRentalBindingNavigatorSaveItem.Text = "Save Data";
            this.registerRentalBindingNavigatorSaveItem.Click += new System.EventHandler(this.registerRentalBindingNavigatorSaveItem_Click);
            // 
            // registerRentalDataGridView
            // 
            this.registerRentalDataGridView.AutoGenerateColumns = false;
            this.registerRentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerRentalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.registerRentalDataGridView.DataSource = this.registerRentalBindingSource;
            this.registerRentalDataGridView.Location = new System.Drawing.Point(350, 25);
            this.registerRentalDataGridView.Name = "registerRentalDataGridView";
            this.registerRentalDataGridView.Size = new System.Drawing.Size(643, 220);
            this.registerRentalDataGridView.TabIndex = 1;
            this.registerRentalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerRentalDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Booking Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "Booking Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Personal Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Personal Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Vehicle Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Vehicle Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Current Distance";
            this.dataGridViewTextBoxColumn6.HeaderText = "Current Distance";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // registerReturnBindingSource
            // 
            this.registerReturnBindingSource.DataMember = "RegisterReturn";
            this.registerReturnBindingSource.DataSource = this.vehicleDatabaseDataSet1;
            // 
            // registerReturnTableAdapter
            // 
            this.registerReturnTableAdapter.ClearBeforeFill = true;
            // 
            // booking_NumberLabel
            // 
            booking_NumberLabel.AutoSize = true;
            booking_NumberLabel.Location = new System.Drawing.Point(12, 28);
            booking_NumberLabel.Name = "booking_NumberLabel";
            booking_NumberLabel.Size = new System.Drawing.Size(89, 13);
            booking_NumberLabel.TabIndex = 2;
            booking_NumberLabel.Text = "Booking Number:";
            // 
            // booking_NumberTextBox
            // 
            this.booking_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerRentalBindingSource, "Booking Number", true));
            this.booking_NumberTextBox.Location = new System.Drawing.Point(109, 25);
            this.booking_NumberTextBox.Name = "booking_NumberTextBox";
            this.booking_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.booking_NumberTextBox.TabIndex = 3;
            // 
            // personal_NumberLabel
            // 
            personal_NumberLabel.AutoSize = true;
            personal_NumberLabel.Location = new System.Drawing.Point(12, 54);
            personal_NumberLabel.Name = "personal_NumberLabel";
            personal_NumberLabel.Size = new System.Drawing.Size(91, 13);
            personal_NumberLabel.TabIndex = 4;
            personal_NumberLabel.Text = "Personal Number:";
            // 
            // personal_NumberTextBox
            // 
            this.personal_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerRentalBindingSource, "Personal Number", true));
            this.personal_NumberTextBox.Location = new System.Drawing.Point(109, 51);
            this.personal_NumberTextBox.Name = "personal_NumberTextBox";
            this.personal_NumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.personal_NumberTextBox.TabIndex = 5;
            // 
            // vehicle_CategoryLabel
            // 
            vehicle_CategoryLabel.AutoSize = true;
            vehicle_CategoryLabel.Location = new System.Drawing.Point(12, 80);
            vehicle_CategoryLabel.Name = "vehicle_CategoryLabel";
            vehicle_CategoryLabel.Size = new System.Drawing.Size(90, 13);
            vehicle_CategoryLabel.TabIndex = 6;
            vehicle_CategoryLabel.Text = "Vehicle Category:";
            // 
            // vehicle_CategoryTextBox
            // 
            this.vehicle_CategoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerRentalBindingSource, "Vehicle Category", true));
            this.vehicle_CategoryTextBox.Location = new System.Drawing.Point(109, 77);
            this.vehicle_CategoryTextBox.Name = "vehicle_CategoryTextBox";
            this.vehicle_CategoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicle_CategoryTextBox.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(12, 107);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "Date:";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registerRentalBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(109, 103);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(12, 132);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(33, 13);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "Time:";
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerRentalBindingSource, "Time", true));
            this.timeTextBox.Location = new System.Drawing.Point(109, 129);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 20);
            this.timeTextBox.TabIndex = 11;
            // 
            // current_DistanceLabel
            // 
            current_DistanceLabel.AutoSize = true;
            current_DistanceLabel.Location = new System.Drawing.Point(12, 158);
            current_DistanceLabel.Name = "current_DistanceLabel";
            current_DistanceLabel.Size = new System.Drawing.Size(89, 13);
            current_DistanceLabel.TabIndex = 12;
            current_DistanceLabel.Text = "Current Distance:";
            // 
            // current_DistanceTextBox
            // 
            this.current_DistanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerRentalBindingSource, "Current Distance", true));
            this.current_DistanceTextBox.Location = new System.Drawing.Point(109, 155);
            this.current_DistanceTextBox.Name = "current_DistanceTextBox";
            this.current_DistanceTextBox.Size = new System.Drawing.Size(200, 20);
            this.current_DistanceTextBox.TabIndex = 13;
            // 
            // registerReturnDataGridView
            // 
            this.registerReturnDataGridView.AutoGenerateColumns = false;
            this.registerReturnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerReturnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.registerReturnDataGridView.DataSource = this.registerReturnBindingSource;
            this.registerReturnDataGridView.Location = new System.Drawing.Point(350, 303);
            this.registerReturnDataGridView.Name = "registerReturnDataGridView";
            this.registerReturnDataGridView.Size = new System.Drawing.Size(593, 220);
            this.registerReturnDataGridView.TabIndex = 14;
            this.registerReturnDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registerReturnDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Booking Number";
            this.dataGridViewTextBoxColumn7.HeaderText = "Booking Number";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Time";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Current Distance";
            this.dataGridViewTextBoxColumn10.HeaderText = "Current Distance";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // booking_NumberLabel1
            // 
            booking_NumberLabel1.AutoSize = true;
            booking_NumberLabel1.Location = new System.Drawing.Point(14, 306);
            booking_NumberLabel1.Name = "booking_NumberLabel1";
            booking_NumberLabel1.Size = new System.Drawing.Size(89, 13);
            booking_NumberLabel1.TabIndex = 15;
            booking_NumberLabel1.Text = "Booking Number:";
            // 
            // booking_NumberTextBox1
            // 
            this.booking_NumberTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerReturnBindingSource, "Booking Number", true));
            this.booking_NumberTextBox1.Location = new System.Drawing.Point(109, 303);
            this.booking_NumberTextBox1.Name = "booking_NumberTextBox1";
            this.booking_NumberTextBox1.Size = new System.Drawing.Size(200, 20);
            this.booking_NumberTextBox1.TabIndex = 16;
            // 
            // dateLabel1
            // 
            dateLabel1.AutoSize = true;
            dateLabel1.Location = new System.Drawing.Point(14, 333);
            dateLabel1.Name = "dateLabel1";
            dateLabel1.Size = new System.Drawing.Size(33, 13);
            dateLabel1.TabIndex = 17;
            dateLabel1.Text = "Date:";
            // 
            // dateDateTimePicker1
            // 
            this.dateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.registerReturnBindingSource, "Date", true));
            this.dateDateTimePicker1.Location = new System.Drawing.Point(109, 329);
            this.dateDateTimePicker1.Name = "dateDateTimePicker1";
            this.dateDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker1.TabIndex = 18;
            // 
            // timeLabel1
            // 
            timeLabel1.AutoSize = true;
            timeLabel1.Location = new System.Drawing.Point(14, 358);
            timeLabel1.Name = "timeLabel1";
            timeLabel1.Size = new System.Drawing.Size(33, 13);
            timeLabel1.TabIndex = 19;
            timeLabel1.Text = "Time:";
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerReturnBindingSource, "Time", true));
            this.timeTextBox1.Location = new System.Drawing.Point(109, 355);
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(200, 20);
            this.timeTextBox1.TabIndex = 20;
            // 
            // current_DistanceLabel1
            // 
            current_DistanceLabel1.AutoSize = true;
            current_DistanceLabel1.Location = new System.Drawing.Point(14, 384);
            current_DistanceLabel1.Name = "current_DistanceLabel1";
            current_DistanceLabel1.Size = new System.Drawing.Size(89, 13);
            current_DistanceLabel1.TabIndex = 21;
            current_DistanceLabel1.Text = "Current Distance:";
            // 
            // current_DistanceTextBox1
            // 
            this.current_DistanceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registerReturnBindingSource, "Current Distance", true));
            this.current_DistanceTextBox1.Location = new System.Drawing.Point(109, 381);
            this.current_DistanceTextBox1.Name = "current_DistanceTextBox1";
            this.current_DistanceTextBox1.Size = new System.Drawing.Size(200, 20);
            this.current_DistanceTextBox1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 642);
            this.Controls.Add(booking_NumberLabel1);
            this.Controls.Add(this.booking_NumberTextBox1);
            this.Controls.Add(dateLabel1);
            this.Controls.Add(this.dateDateTimePicker1);
            this.Controls.Add(timeLabel1);
            this.Controls.Add(this.timeTextBox1);
            this.Controls.Add(current_DistanceLabel1);
            this.Controls.Add(this.current_DistanceTextBox1);
            this.Controls.Add(this.registerReturnDataGridView);
            this.Controls.Add(booking_NumberLabel);
            this.Controls.Add(this.booking_NumberTextBox);
            this.Controls.Add(personal_NumberLabel);
            this.Controls.Add(this.personal_NumberTextBox);
            this.Controls.Add(vehicle_CategoryLabel);
            this.Controls.Add(this.vehicle_CategoryTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(timeLabel);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(current_DistanceLabel);
            this.Controls.Add(this.current_DistanceTextBox);
            this.Controls.Add(this.registerRentalDataGridView);
            this.Controls.Add(this.registerRentalBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalBindingNavigator)).EndInit();
            this.registerRentalBindingNavigator.ResumeLayout(false);
            this.registerRentalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerRentalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerReturnBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private VehicleDatabaseDataSet1TableAdapters.RegisterReturnTableAdapter registerReturnTableAdapter;
        private System.Windows.Forms.BindingSource registerReturnBindingSource;
        private System.Windows.Forms.TextBox booking_NumberTextBox;
        private System.Windows.Forms.TextBox personal_NumberTextBox;
        private System.Windows.Forms.TextBox vehicle_CategoryTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox current_DistanceTextBox;
        private System.Windows.Forms.DataGridView registerReturnDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox booking_NumberTextBox1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker1;
        private System.Windows.Forms.TextBox timeTextBox1;
        private System.Windows.Forms.TextBox current_DistanceTextBox1;
    }
}

