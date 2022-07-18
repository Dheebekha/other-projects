namespace Furniture_house_Application
{
    partial class frm_DisplayResults
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
            this.lbl_ActualAmount = new System.Windows.Forms.Label();
            this.lbl_ActualAmountResult = new System.Windows.Forms.Label();
            this.lbl_DiscountPercent = new System.Windows.Forms.Label();
            this.lbl_DiscountPercentResult = new System.Windows.Forms.Label();
            this.lbl_FinalAmount = new System.Windows.Forms.Label();
            this.lbl_FinalAmountResult = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ActualAmount
            // 
            this.lbl_ActualAmount.AutoSize = true;
            this.lbl_ActualAmount.Location = new System.Drawing.Point(89, 78);
            this.lbl_ActualAmount.Name = "lbl_ActualAmount";
            this.lbl_ActualAmount.Size = new System.Drawing.Size(200, 32);
            this.lbl_ActualAmount.TabIndex = 0;
            this.lbl_ActualAmount.Text = "Actual Amount";
            // 
            // lbl_ActualAmountResult
            // 
            this.lbl_ActualAmountResult.AutoSize = true;
            this.lbl_ActualAmountResult.Location = new System.Drawing.Point(381, 78);
            this.lbl_ActualAmountResult.Name = "lbl_ActualAmountResult";
            this.lbl_ActualAmountResult.Size = new System.Drawing.Size(0, 32);
            this.lbl_ActualAmountResult.TabIndex = 1;
            // 
            // lbl_DiscountPercent
            // 
            this.lbl_DiscountPercent.AutoSize = true;
            this.lbl_DiscountPercent.Location = new System.Drawing.Point(89, 152);
            this.lbl_DiscountPercent.Name = "lbl_DiscountPercent";
            this.lbl_DiscountPercent.Size = new System.Drawing.Size(231, 32);
            this.lbl_DiscountPercent.TabIndex = 2;
            this.lbl_DiscountPercent.Text = "Discount Percent";
            // 
            // lbl_DiscountPercentResult
            // 
            this.lbl_DiscountPercentResult.AutoSize = true;
            this.lbl_DiscountPercentResult.Location = new System.Drawing.Point(381, 152);
            this.lbl_DiscountPercentResult.Name = "lbl_DiscountPercentResult";
            this.lbl_DiscountPercentResult.Size = new System.Drawing.Size(0, 32);
            this.lbl_DiscountPercentResult.TabIndex = 3;
            // 
            // lbl_FinalAmount
            // 
            this.lbl_FinalAmount.AutoSize = true;
            this.lbl_FinalAmount.Location = new System.Drawing.Point(89, 223);
            this.lbl_FinalAmount.Name = "lbl_FinalAmount";
            this.lbl_FinalAmount.Size = new System.Drawing.Size(183, 32);
            this.lbl_FinalAmount.TabIndex = 4;
            this.lbl_FinalAmount.Text = "Final Amount";
            // 
            // lbl_FinalAmountResult
            // 
            this.lbl_FinalAmountResult.AutoSize = true;
            this.lbl_FinalAmountResult.Location = new System.Drawing.Point(381, 223);
            this.lbl_FinalAmountResult.Name = "lbl_FinalAmountResult";
            this.lbl_FinalAmountResult.Size = new System.Drawing.Size(0, 32);
            this.lbl_FinalAmountResult.TabIndex = 5;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(206, 313);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(193, 67);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_DisplayResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 513);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.lbl_FinalAmountResult);
            this.Controls.Add(this.lbl_FinalAmount);
            this.Controls.Add(this.lbl_DiscountPercentResult);
            this.Controls.Add(this.lbl_DiscountPercent);
            this.Controls.Add(this.lbl_ActualAmountResult);
            this.Controls.Add(this.lbl_ActualAmount);
            this.Name = "frm_DisplayResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase Amount";
            this.Load += new System.EventHandler(this.frm_DisplayResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ActualAmount;
        private System.Windows.Forms.Label lbl_ActualAmountResult;
        private System.Windows.Forms.Label lbl_DiscountPercent;
        private System.Windows.Forms.Label lbl_DiscountPercentResult;
        private System.Windows.Forms.Label lbl_FinalAmount;
        private System.Windows.Forms.Label lbl_FinalAmountResult;
        private System.Windows.Forms.Button btn_OK;
    }
}