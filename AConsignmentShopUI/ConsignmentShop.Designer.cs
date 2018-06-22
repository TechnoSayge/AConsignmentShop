namespace AConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.lblItemsListBoxLabel = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblShoppingCartListBox = new System.Windows.Forms.Label();
            this.lbShoppingCart = new System.Windows.Forms.ListBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.Location = new System.Drawing.Point(23, 9);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(405, 37);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "Consignment Shop Demo";
            // 
            // lbItems
            // 
            this.lbItems.FormattingEnabled = true;
            this.lbItems.ItemHeight = 20;
            this.lbItems.Location = new System.Drawing.Point(30, 143);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(205, 184);
            this.lbItems.TabIndex = 1;
            // 
            // lblItemsListBoxLabel
            // 
            this.lblItemsListBoxLabel.AutoSize = true;
            this.lblItemsListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsListBoxLabel.Location = new System.Drawing.Point(26, 120);
            this.lblItemsListBoxLabel.Name = "lblItemsListBoxLabel";
            this.lblItemsListBoxLabel.Size = new System.Drawing.Size(103, 20);
            this.lblItemsListBoxLabel.TabIndex = 2;
            this.lblItemsListBoxLabel.Text = "Store Items";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(250, 202);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(123, 38);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart->";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // lblShoppingCartListBox
            // 
            this.lblShoppingCartListBox.AutoSize = true;
            this.lblShoppingCartListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCartListBox.Location = new System.Drawing.Point(388, 120);
            this.lblShoppingCartListBox.Name = "lblShoppingCartListBox";
            this.lblShoppingCartListBox.Size = new System.Drawing.Size(124, 20);
            this.lblShoppingCartListBox.TabIndex = 5;
            this.lblShoppingCartListBox.Text = "Shopping Cart";
            // 
            // lbShoppingCart
            // 
            this.lbShoppingCart.FormattingEnabled = true;
            this.lbShoppingCart.ItemHeight = 20;
            this.lbShoppingCart.Location = new System.Drawing.Point(392, 143);
            this.lbShoppingCart.Name = "lbShoppingCart";
            this.lbShoppingCart.Size = new System.Drawing.Size(205, 184);
            this.lbShoppingCart.TabIndex = 4;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(474, 333);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(123, 38);
            this.btnPurchase.TabIndex = 6;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 392);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblShoppingCartListBox);
            this.Controls.Add(this.lbShoppingCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblItemsListBoxLabel);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.lblHeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop Demo";
            this.Load += new System.EventHandler(this.ConsignmentShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Label lblItemsListBoxLabel;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblShoppingCartListBox;
        private System.Windows.Forms.ListBox lbShoppingCart;
        private System.Windows.Forms.Button btnPurchase;
    }
}

