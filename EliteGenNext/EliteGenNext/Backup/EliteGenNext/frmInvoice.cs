/*
 * frmInvoice.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EliteGenNext
{
    /// <summary>
    /// Class frmInvoice is used to demonstrate the use of DataSets and DataTables.
    /// Class frmInvoice displays the details of invoice.
    /// </summary>
    public partial class frmInvoice : Form
    {
        SqlConnection sqlconInvoice;
        DataSet dsetInvoice;

        /// <summary>
        /// Constructor without parameters to initialize the
        /// controls for displaying the invoice details. 
        /// </summary>
        public frmInvoice()
        {
            InitializeComponent();
            sqlconInvoice = new SqlConnection("Data Source=globe;Initial Catalog=EliteGenNext;Integrated Security=SSPI");
            dsetInvoice = new DataSet();
        }

        // Loads the frmInvoice form.
        private void frmInvoice_Load(object sender, EventArgs e)
        {
            sqlconInvoice.Open();

            SqlDataAdapter sqldaInvoice = new SqlDataAdapter("SELECT * FROM Invoice", sqlconInvoice);
            int invoiceRows = sqldaInvoice.Fill(dsetInvoice, "Invoice");

            SqlDataAdapter sqldaInvoiceDetails = new SqlDataAdapter("SELECT * FROM InvoiceDetails", sqlconInvoice);
            int invoiceDetailsRows = sqldaInvoiceDetails.Fill(dsetInvoice, "InvoiceDetails");

            DataTable dtableInvoice = dsetInvoice.Tables["Invoice"];
            DataTable dtableInvoiceDetails = dsetInvoice.Tables["InvoiceDetails"];

            DataColumn dcolInvoice = dtableInvoice.Columns["InvoiceNo"];
            DataColumn dcolInvoiceDetails = dtableInvoiceDetails.Columns["InvoiceNo"];
            DataRelation drelationInvoice = new DataRelation("InvoiceDet", dcolInvoice, dcolInvoiceDetails);

            dsetInvoice.Relations.Add(drelationInvoice);

            cboInvoiceNo.DataSource = dsetInvoice.Tables["Invoice"];
            cboInvoiceNo.DisplayMember = "InvoiceNo";
            cboInvoiceNo.ValueMember = "InvoiceNo";

        }

        // Displays the invoice details.
        private void cboInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvwInvoiceDetails.Items.Clear();
            DataRow drowInvoice = dsetInvoice.Tables["Invoice"].Rows[cboInvoiceNo.SelectedIndex];
            {
                txtInvoiceDate.Text = Convert.ToDateTime(drowInvoice["InvoiceDate"]).ToString("MM/dd/yyyy");
                txtCustomerName.Text = drowInvoice["CustomerName"].ToString();
                lblQuantity.Text = drowInvoice["TotalQuantity"].ToString();
                lblAmount.Text = string.Format("{0:C}", drowInvoice["TotalAmount"]);

                foreach (DataRow drowInvoiceDetails in drowInvoice.GetChildRows(dsetInvoice.Relations["InvoiceDet"]))
                {
                    ListViewItem lviDetails = new ListViewItem(drowInvoiceDetails["ProductID"].ToString());
                    lviDetails.SubItems.Add(drowInvoiceDetails["Description"].ToString());
                    lviDetails.SubItems.Add(string.Format("{0:C}", drowInvoiceDetails["Price"]));
                    lviDetails.SubItems.Add(drowInvoiceDetails["Quantity"].ToString());
                    lviDetails.SubItems.Add(string.Format("{0:C}", drowInvoiceDetails["Amount"]));
                    lvwInvoiceDetails.Items.Add(lviDetails);
                }
            }
        }
    }
}