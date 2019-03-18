namespace Lab4
{
    partial class UpdateForm
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label shippedDateLabel;
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.DTPShippedDate = new System.Windows.Forms.DateTimePicker();
            customerIDLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            orderIDLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 67);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(68, 13);
            customerIDLabel.TabIndex = 12;
            customerIDLabel.Text = "Customer ID:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(12, 93);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 14;
            orderDateLabel.Text = "Order Date:";
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(12, 41);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 16;
            orderIDLabel.Text = "Order ID:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(12, 121);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 18;
            requiredDateLabel.Text = "Required Date:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(12, 148);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 20;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(182, 179);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Enabled = false;
            this.txtOrderId.Location = new System.Drawing.Point(108, 34);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(84, 20);
            this.txtOrderId.TabIndex = 21;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Enabled = false;
            this.txtRequiredDate.Location = new System.Drawing.Point(108, 114);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(149, 20);
            this.txtRequiredDate.TabIndex = 22;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Location = new System.Drawing.Point(108, 86);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(149, 20);
            this.txtOrderDate.TabIndex = 23;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Enabled = false;
            this.txtCustomerId.Location = new System.Drawing.Point(108, 60);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(84, 20);
            this.txtCustomerId.TabIndex = 24;
            // 
            // DTPShippedDate
            // 
            this.DTPShippedDate.Location = new System.Drawing.Point(108, 140);
            this.DTPShippedDate.Name = "DTPShippedDate";
            this.DTPShippedDate.Size = new System.Drawing.Size(149, 20);
            this.DTPShippedDate.TabIndex = 25;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 232);
            this.Controls.Add(this.DTPShippedDate);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.DateTimePicker DTPShippedDate;
    }
}