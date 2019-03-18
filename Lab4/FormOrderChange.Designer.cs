namespace Lab4
{
    partial class FormOrderChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
                
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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderIDComboBox = new System.Windows.Forms.ComboBox();
            this.requiredDateTextBox = new System.Windows.Forms.TextBox();
            this.shippedDateTextBox = new System.Windows.Forms.TextBox();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(BusinessClasses.Orders);
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(BusinessClasses.OrderDetails);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(391, 116);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(73, 66);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 12;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(158, 63);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerIDTextBox.TabIndex = 13;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(73, 92);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 14;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderDate", true));
            this.orderDateTextBox.Location = new System.Drawing.Point(158, 89);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.orderDateTextBox.TabIndex = 15;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(73, 118);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 16;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDComboBox
            // 
            this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDComboBox.FormattingEnabled = true;
            this.orderIDComboBox.Location = new System.Drawing.Point(158, 115);
            this.orderIDComboBox.Name = "orderIDComboBox";
            this.orderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderIDComboBox.TabIndex = 17;
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(73, 145);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 18;
            requiredDateLabel.Text = "Required Date:";
            // 
            // requiredDateTextBox
            // 
            this.requiredDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateTextBox.Location = new System.Drawing.Point(158, 142);
            this.requiredDateTextBox.Name = "requiredDateTextBox";
            this.requiredDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.requiredDateTextBox.TabIndex = 19;
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(73, 171);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 20;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shippedDateTextBox
            // 
            this.shippedDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateTextBox.Location = new System.Drawing.Point(158, 168);
            this.shippedDateTextBox.Name = "shippedDateTextBox";
            this.shippedDateTextBox.Size = new System.Drawing.Size(121, 20);
            this.shippedDateTextBox.TabIndex = 21;
            // 
            // FormOrderChange
            

        }

        #endregion

        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.ComboBox orderIDComboBox;
        private System.Windows.Forms.TextBox requiredDateTextBox;
        private System.Windows.Forms.TextBox shippedDateTextBox;
    }
}

