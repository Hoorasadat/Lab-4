namespace Lab4
{
    partial class OrderForm
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderIDComboBox = new System.Windows.Forms.ComboBox();
            this.requiredDateTextBox = new System.Windows.Forms.TextBox();
            this.shippedDateTextBox = new System.Windows.Forms.TextBox();
            this.orderDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(7, 90);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(7, 116);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 3;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(7, 63);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 5;
            orderIDLabel.Text = "Order ID:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(7, 143);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 7;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(7, 169);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 9;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = null;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = null;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BusinessClasses.Order);
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
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CustomerID", true));
            this.customerIDTextBox.Enabled = false;
            this.customerIDTextBox.Location = new System.Drawing.Point(92, 87);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.orderDateTextBox.Enabled = false;
            this.orderDateTextBox.Location = new System.Drawing.Point(92, 113);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.orderDateTextBox.TabIndex = 4;
            // 
            // orderIDComboBox
            // 
            this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
            this.orderIDComboBox.DataSource = this.orderBindingSource;
            this.orderIDComboBox.DisplayMember = "OrderID";
            this.orderIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderIDComboBox.FormattingEnabled = true;
            this.orderIDComboBox.Location = new System.Drawing.Point(92, 60);
            this.orderIDComboBox.Name = "orderIDComboBox";
            this.orderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderIDComboBox.TabIndex = 6;
            this.orderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.orderIDComboBox_SelectedIndexChanged);
            this.orderIDComboBox.TextChanged += new System.EventHandler(this.orderIDComboBox_SelectedIndexChanged);
            // 
            // requiredDateTextBox
            // 
            this.requiredDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "RequiredDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.requiredDateTextBox.Enabled = false;
            this.requiredDateTextBox.Location = new System.Drawing.Point(92, 140);
            this.requiredDateTextBox.Name = "requiredDateTextBox";
            this.requiredDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.requiredDateTextBox.TabIndex = 8;
            // 
            // shippedDateTextBox
            // 
            this.shippedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ShippedDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.shippedDateTextBox.Enabled = false;
            this.shippedDateTextBox.Location = new System.Drawing.Point(92, 166);
            this.shippedDateTextBox.Name = "shippedDateTextBox";
            this.shippedDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.shippedDateTextBox.TabIndex = 10;
            // 
            // orderDetailsDataGridView
            // 
            this.orderDetailsDataGridView.AllowUserToAddRows = false;
            this.orderDetailsDataGridView.AllowUserToDeleteRows = false;
            this.orderDetailsDataGridView.AutoGenerateColumns = false;
            this.orderDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.orderDetailsDataGridView.DataSource = this.orderDetailsBindingSource;
            this.orderDetailsDataGridView.Enabled = false;
            this.orderDetailsDataGridView.Location = new System.Drawing.Point(10, 285);
            this.orderDetailsDataGridView.Name = "orderDetailsDataGridView";
            this.orderDetailsDataGridView.ReadOnly = true;
            this.orderDetailsDataGridView.Size = new System.Drawing.Size(544, 220);
            this.orderDetailsDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(BusinessClasses.OrderDetails);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(26, 239);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToAddRows = false;
            this.orderDataGridView.AllowUserToDeleteRows = false;
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(228, 60);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.ReadOnly = true;
            this.orderDataGridView.Size = new System.Drawing.Size(561, 202);
            this.orderDataGridView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.Location = new System.Drawing.Point(113, 198);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn7.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RequiredDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn9.HeaderText = "RequiredDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ShippedDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn10.HeaderText = "ShippedDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 507);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.orderDetailsDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDComboBox);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateTextBox);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateTextBox);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "OrderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.ComboBox orderIDComboBox;
        private System.Windows.Forms.TextBox requiredDateTextBox;
        private System.Windows.Forms.TextBox shippedDateTextBox;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.DataGridView orderDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}

