namespace Furniture_house_Application
{
    partial class frm_FurnitureHouse
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
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.lbl_Product = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.cmb_ProductName = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_CustomerName = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Location = new System.Drawing.Point(114, 99);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(219, 32);
            this.lbl_CustomerName.TabIndex = 0;
            this.lbl_CustomerName.Text = "Customer Name";
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Location = new System.Drawing.Point(114, 180);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(195, 32);
            this.lbl_Product.TabIndex = 2;
            this.lbl_Product.Text = "Product Name";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(123, 263);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(122, 32);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Quantity.Location = new System.Drawing.Point(423, 257);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(290, 38);
            this.txt_Quantity.TabIndex = 5;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(266, 362);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(254, 54);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // cmb_ProductName
            // 
            this.cmb_ProductName.BackColor = System.Drawing.SystemColors.Menu;
            this.cmb_ProductName.DataSource = this.bindingSource2;
            this.cmb_ProductName.DisplayMember = "Product_Name";
            this.cmb_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductName.FormattingEnabled = true;
            this.cmb_ProductName.Location = new System.Drawing.Point(423, 173);
            this.cmb_ProductName.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_ProductName.Name = "cmb_ProductName";
            this.cmb_ProductName.Size = new System.Drawing.Size(290, 39);
            this.cmb_ProductName.TabIndex = 7;
            this.cmb_ProductName.ValueMember = "Product_Id";
            this.cmb_ProductName.SelectionChangeCommitted += new System.EventHandler(this.cmb_ProductName_SelectionChangeCommitted);
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Products";
            
            // cmb_CustomerName
            // 
            this.cmb_CustomerName.BackColor = System.Drawing.SystemColors.Menu;
            this.cmb_CustomerName.DataSource = this.bindingSource1;
            this.cmb_CustomerName.DisplayMember = "Customer_Name";
            this.cmb_CustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CustomerName.FormattingEnabled = true;
            this.cmb_CustomerName.Location = new System.Drawing.Point(423, 99);
            this.cmb_CustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_CustomerName.Name = "cmb_CustomerName";
            this.cmb_CustomerName.Size = new System.Drawing.Size(290, 39);
            this.cmb_CustomerName.TabIndex = 8;
            this.cmb_CustomerName.ValueMember = "Customer_Id";
            this.cmb_CustomerName.SelectionChangeCommitted += new System.EventHandler(this.cmb_CustomerName_SelectionChangeCommitted);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Customers";
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(968, 912);
            this.Controls.Add(this.cmb_CustomerName);
            this.Controls.Add(this.cmb_ProductName);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Product);
            this.Controls.Add(this.lbl_CustomerName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_FurnitureHouse";
            this.Text = "Furniture House";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frm_FurnitureHouse_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.ComboBox cmb_ProductName;
        private System.Windows.Forms.ComboBox cmb_CustomerName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}


