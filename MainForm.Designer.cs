namespace CSharpWinFormsPOS
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProcessSale;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProcessSale = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(30, 20);
            this.lblItem.Text = "Item";
            this.lblItem.AutoSize = true;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(120, 20);
            this.txtItem.Size = new System.Drawing.Size(150, 22);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(30, 50);
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.AutoSize = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 50);
            this.txtQuantity.Size = new System.Drawing.Size(150, 22);
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(30, 80);
            this.lblPrice.Text = "Price";
            this.lblPrice.AutoSize = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(120, 80);
            this.txtPrice.Size = new System.Drawing.Size(150, 22);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(30, 110);
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.AutoSize = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(120, 110);
            this.txtDiscount.Size = new System.Drawing.Size(150, 22);
            // 
            // btnProcessSale
            // 
            this.btnProcessSale.Location = new System.Drawing.Point(100, 150);
            this.btnProcessSale.Name = "btnProcessSale";
            this.btnProcessSale.Size = new System.Drawing.Size(120, 30);
            this.btnProcessSale.TabIndex = 0;
            this.btnProcessSale.Text = "Process Sale";
            this.btnProcessSale.UseVisualStyleBackColor = true;
            this.btnProcessSale.Click += new System.EventHandler(this.btnProcessSale_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.btnProcessSale);
            this.Name = "MainForm";
            this.Text = "Enhanced POS App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}