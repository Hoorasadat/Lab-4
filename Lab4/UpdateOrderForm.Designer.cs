namespace Lab4
{
    partial class UpdateOrderForm
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
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.orderDateTextBox = new System.Windows.Forms.TextBox();
            this.orderIDTextBox = new System.Windows.Forms.TextBox();
            this.requiredDateTextBox = new System.Windows.Forms.TextBox();
            this.shippedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(BusinessClasses.Orders);
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(39, 89);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Enabled = false;
            this.customerIDTextBox.Location = new System.Drawing.Point(124, 86);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(39, 115);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 2;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderDate", true));
            this.orderDateTextBox.Enabled = false;
            this.orderDateTextBox.Location = new System.Drawing.Point(124, 112);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderDateTextBox.TabIndex = 3;
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(39, 63);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 4;
            orderIDLabel.Text = "Order ID:";
            // 
            // orderIDTextBox
            // 
            this.orderIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "OrderID", true));
            this.orderIDTextBox.Location = new System.Drawing.Point(124, 60);
            this.orderIDTextBox.Name = "orderIDTextBox";
            this.orderIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.orderIDTextBox.TabIndex = 5;
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(39, 141);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 6;
            requiredDateLabel.Text = "Required Date:";
            // 
            // requiredDateTextBox
            // 
            this.requiredDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "RequiredDate", true));
            this.requiredDateTextBox.Enabled = false;
            this.requiredDateTextBox.Location = new System.Drawing.Point(124, 138);
            this.requiredDateTextBox.Name = "requiredDateTextBox";
            this.requiredDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.requiredDateTextBox.TabIndex = 7;
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(39, 168);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 8;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // shippedDateDateTimePicker
            // 
            this.shippedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "ShippedDate", true));
            this.shippedDateDateTimePicker.Location = new System.Drawing.Point(124, 164);
            this.shippedDateDateTimePicker.Name = "shippedDateDateTimePicker";
            this.shippedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shippedDateDateTimePicker.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(124, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 295);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDTextBox);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateTextBox);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateDateTimePicker);
            this.Name = "UpdateOrder";
            this.Text = "Update Order";
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox orderDateTextBox;
        private System.Windows.Forms.TextBox orderIDTextBox;
        private System.Windows.Forms.TextBox requiredDateTextBox;
        private System.Windows.Forms.DateTimePicker shippedDateDateTimePicker;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}