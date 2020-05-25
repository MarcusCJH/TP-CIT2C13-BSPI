using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using SCMSystem.classes;

namespace SCMSystem
{
    public partial class InvoiceSummary : Form
    {
        public InvoiceSummary()
        {
            InitializeComponent();
        }

        private void btnCloseSumary_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblInvoiceIDText.Text))
            {
                MessageBox.Show("There is nothing to print.");

            }
            else
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += this.Doc_PrintPage;
                PrintDialog dlgSettings = new PrintDialog();
                dlgSettings.Document = doc;
                if (dlgSettings.ShowDialog() == DialogResult.OK)
                {
                    doc.Print();
                }
            }
            

        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            float x = 0;
            float y = 0;
            Bitmap bmp = new Bitmap(this.grpBoxInvoiceSummaries.ClientRectangle.Width, this.grpBoxInvoiceSummaries.ClientRectangle.Height);
            this.grpBoxInvoiceSummaries.DrawToBitmap(bmp, new Rectangle(0, 0, this.grpBoxInvoiceSummaries.Width, this.grpBoxInvoiceSummaries.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }

        private void InvoiceSummary_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set 'x' to false to remove the 'x'
            this.ControlBox = false;


            // Start
            SCMDBManager.FillDropDownListInvoiceID(cbBoxInvoiceID);
            SCMDBManager.ListViewInvoiceID(lvInoiceIDList);
        }

        private void cbBoxInvoiceID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string id = cbBoxInvoiceID.SelectedItem.ToString();
            SCMDBManager.ListViewInvoiceItem(lvInvoiceInvoice, id);
            Invoice i = SCMDBManager.GetInvoiceDetailsByID(id);
            lblInvoiceIDText.Text = id;
            lblInvoiceDateText.Text = i.InvoiceDate;
            lblSellerIDText.Text = i.SellerID;
            lblBuyerIDText.Text = "GFS1810";
            lblOrderIDText.Text = i.OrderID;
            lblShippingChargesText.Text = i.ShippingCharges.ToString();
            lblAmountPayableText.Text = i.InvoiceTotal.ToString();
            
        }

        
    }
}
