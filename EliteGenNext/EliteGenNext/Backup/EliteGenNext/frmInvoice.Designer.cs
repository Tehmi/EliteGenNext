/*
 * frmInvoice.Designer.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

namespace EliteGenNext
{
    partial class frmInvoice
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
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.cboInvoiceNo = new System.Windows.Forms.ComboBox();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lvwInvoiceDetails = new System.Windows.Forms.ListView();
            this.productid = new System.Windows.Forms.ColumnHeader();
            this.description = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.amount = new System.Windows.Forms.ColumnHeader();
            this.grpProductDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grpProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(8, 9);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(65, 13);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice No.:";
            // 
            // cboInvoiceNo
            // 
            this.cboInvoiceNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceNo.FormattingEnabled = true;
            this.cboInvoiceNo.Location = new System.Drawing.Point(85, 6);
            this.cboInvoiceNo.Name = "cboInvoiceNo";
            this.cboInvoiceNo.Size = new System.Drawing.Size(90, 21);
            this.cboInvoiceNo.TabIndex = 1;
            this.cboInvoiceNo.SelectedIndexChanged += new System.EventHandler(this.cboInvoiceNo_SelectedIndexChanged);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Location = new System.Drawing.Point(8, 36);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(71, 13);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // lvwInvoiceDetails
            // 
            this.lvwInvoiceDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productid,
            this.description,
            this.price,
            this.quantity,
            this.amount});
            this.lvwInvoiceDetails.FullRowSelect = true;
            this.lvwInvoiceDetails.GridLines = true;
            this.lvwInvoiceDetails.HideSelection = false;
            this.lvwInvoiceDetails.Location = new System.Drawing.Point(10, 17);
            this.lvwInvoiceDetails.Name = "lvwInvoiceDetails";
            this.lvwInvoiceDetails.Size = new System.Drawing.Size(468, 161);
            this.lvwInvoiceDetails.TabIndex = 4;
            this.lvwInvoiceDetails.UseCompatibleStateImageBehavior = false;
            this.lvwInvoiceDetails.View = System.Windows.Forms.View.Details;
            // 
            // productid
            // 
            this.productid.Text = "Product ID";
            this.productid.Width = 96;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 180;
            // 
            // price
            // 
            this.price.Text = "Unit Price";
            this.price.Width = 65;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 56;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 67;
            // 
            // grpProductDetails
            // 
            this.grpProductDetails.Controls.Add(this.lvwInvoiceDetails);
            this.grpProductDetails.Location = new System.Drawing.Point(9, 67);
            this.grpProductDetails.Name = "grpProductDetails";
            this.grpProductDetails.Size = new System.Drawing.Size(489, 189);
            this.grpProductDetails.TabIndex = 6;
            this.grpProductDetails.TabStop = false;
            this.grpProductDetails.Text = "Product Details";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(204, 9);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 7;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(295, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(203, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Location = new System.Drawing.Point(359, 268);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(76, 13);
            this.lblTotalQuantity.TabIndex = 9;
            this.lblTotalQuantity.Text = "Total Quantity:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(359, 294);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(447, 268);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(47, 13);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "TotalQty";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(85, 32);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(90, 20);
            this.txtInvoiceDate.TabIndex = 13;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(445, 294);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "TotalAmt";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 316);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtInvoiceDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.cboInvoiceNo);
            this.Controls.Add(this.grpProductDetails);
            this.Controls.Add(this.lblInvoiceDate);
            this.Name = "frmInvoice";
            this.Text = "Invoice Details";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.grpProductDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceDate;

        #endregion

        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.ComboBox cboInvoiceNo;
        private System.Windows.Forms.ListView lvwInvoiceDetails;
        private System.Windows.Forms.ColumnHeader productid;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.GroupBox grpProductDetails;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAmount;
    }
}
