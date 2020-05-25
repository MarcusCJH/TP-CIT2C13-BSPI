namespace SCMSystem
{
    partial class InvoiceSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceSummary));
            this.grpBoxInvoiceSummaries = new System.Windows.Forms.GroupBox();
            this.grpBoxPayment = new System.Windows.Forms.GroupBox();
            this.lblAmountPayableText = new System.Windows.Forms.Label();
            this.lblShippingChargesText = new System.Windows.Forms.Label();
            this.lblAmountPayable = new System.Windows.Forms.Label();
            this.lblShippingCharges = new System.Windows.Forms.Label();
            this.lvInvoiceInvoice = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpBoxIdentification = new System.Windows.Forms.GroupBox();
            this.lblOrderIDText = new System.Windows.Forms.Label();
            this.lblBuyerIDText = new System.Windows.Forms.Label();
            this.lblSellerIDText = new System.Windows.Forms.Label();
            this.lblInvoiceDateText = new System.Windows.Forms.Label();
            this.lblInvoiceIDText = new System.Windows.Forms.Label();
            this.lblBuyerID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblSellerID = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.btnCloseSumary = new System.Windows.Forms.Button();
            this.lvInoiceIDList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBoxInvoiceID = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpBoxInvoiceSummaries.SuspendLayout();
            this.grpBoxPayment.SuspendLayout();
            this.grpBoxIdentification.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxInvoiceSummaries
            // 
            this.grpBoxInvoiceSummaries.Controls.Add(this.grpBoxPayment);
            this.grpBoxInvoiceSummaries.Controls.Add(this.lvInvoiceInvoice);
            this.grpBoxInvoiceSummaries.Controls.Add(this.grpBoxIdentification);
            this.grpBoxInvoiceSummaries.Location = new System.Drawing.Point(13, 13);
            this.grpBoxInvoiceSummaries.Name = "grpBoxInvoiceSummaries";
            this.grpBoxInvoiceSummaries.Size = new System.Drawing.Size(942, 398);
            this.grpBoxInvoiceSummaries.TabIndex = 1;
            this.grpBoxInvoiceSummaries.TabStop = false;
            this.grpBoxInvoiceSummaries.Text = "Invoice";
            // 
            // grpBoxPayment
            // 
            this.grpBoxPayment.Controls.Add(this.lblAmountPayableText);
            this.grpBoxPayment.Controls.Add(this.lblShippingChargesText);
            this.grpBoxPayment.Controls.Add(this.lblAmountPayable);
            this.grpBoxPayment.Controls.Add(this.lblShippingCharges);
            this.grpBoxPayment.Location = new System.Drawing.Point(6, 296);
            this.grpBoxPayment.Name = "grpBoxPayment";
            this.grpBoxPayment.Size = new System.Drawing.Size(296, 96);
            this.grpBoxPayment.TabIndex = 16;
            this.grpBoxPayment.TabStop = false;
            this.grpBoxPayment.Text = "Payment";
            // 
            // lblAmountPayableText
            // 
            this.lblAmountPayableText.AutoSize = true;
            this.lblAmountPayableText.Location = new System.Drawing.Point(166, 53);
            this.lblAmountPayableText.Name = "lblAmountPayableText";
            this.lblAmountPayableText.Size = new System.Drawing.Size(0, 17);
            this.lblAmountPayableText.TabIndex = 17;
            // 
            // lblShippingChargesText
            // 
            this.lblShippingChargesText.AutoSize = true;
            this.lblShippingChargesText.Location = new System.Drawing.Point(166, 30);
            this.lblShippingChargesText.Name = "lblShippingChargesText";
            this.lblShippingChargesText.Size = new System.Drawing.Size(0, 17);
            this.lblShippingChargesText.TabIndex = 16;
            // 
            // lblAmountPayable
            // 
            this.lblAmountPayable.AutoSize = true;
            this.lblAmountPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPayable.Location = new System.Drawing.Point(29, 53);
            this.lblAmountPayable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountPayable.Name = "lblAmountPayable";
            this.lblAmountPayable.Size = new System.Drawing.Size(130, 20);
            this.lblAmountPayable.TabIndex = 16;
            this.lblAmountPayable.Text = "AmountPayable:";
            // 
            // lblShippingCharges
            // 
            this.lblShippingCharges.AutoSize = true;
            this.lblShippingCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingCharges.Location = new System.Drawing.Point(8, 30);
            this.lblShippingCharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingCharges.Name = "lblShippingCharges";
            this.lblShippingCharges.Size = new System.Drawing.Size(151, 20);
            this.lblShippingCharges.TabIndex = 16;
            this.lblShippingCharges.Text = "Shipping Charges: ";
            // 
            // lvInvoiceInvoice
            // 
            this.lvInvoiceInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvInvoiceInvoice.GridLines = true;
            this.lvInvoiceInvoice.Location = new System.Drawing.Point(6, 21);
            this.lvInvoiceInvoice.Name = "lvInvoiceInvoice";
            this.lvInvoiceInvoice.Size = new System.Drawing.Size(714, 246);
            this.lvInvoiceInvoice.TabIndex = 30;
            this.lvInvoiceInvoice.UseCompatibleStateImageBehavior = false;
            this.lvInvoiceInvoice.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ProductID";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Colour";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 173;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Quantity";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Unit Price";
            this.columnHeader7.Width = 113;
            // 
            // grpBoxIdentification
            // 
            this.grpBoxIdentification.Controls.Add(this.lblOrderIDText);
            this.grpBoxIdentification.Controls.Add(this.lblBuyerIDText);
            this.grpBoxIdentification.Controls.Add(this.lblSellerIDText);
            this.grpBoxIdentification.Controls.Add(this.lblInvoiceDateText);
            this.grpBoxIdentification.Controls.Add(this.lblInvoiceIDText);
            this.grpBoxIdentification.Controls.Add(this.lblBuyerID);
            this.grpBoxIdentification.Controls.Add(this.lblOrderID);
            this.grpBoxIdentification.Controls.Add(this.lblInvoiceID);
            this.grpBoxIdentification.Controls.Add(this.lblSellerID);
            this.grpBoxIdentification.Controls.Add(this.lblInvoiceDate);
            this.grpBoxIdentification.Location = new System.Drawing.Point(720, 21);
            this.grpBoxIdentification.Name = "grpBoxIdentification";
            this.grpBoxIdentification.Size = new System.Drawing.Size(216, 169);
            this.grpBoxIdentification.TabIndex = 0;
            this.grpBoxIdentification.TabStop = false;
            this.grpBoxIdentification.Text = "Identification";
            // 
            // lblOrderIDText
            // 
            this.lblOrderIDText.AutoSize = true;
            this.lblOrderIDText.Location = new System.Drawing.Point(116, 143);
            this.lblOrderIDText.Name = "lblOrderIDText";
            this.lblOrderIDText.Size = new System.Drawing.Size(0, 17);
            this.lblOrderIDText.TabIndex = 29;
            // 
            // lblBuyerIDText
            // 
            this.lblBuyerIDText.AutoSize = true;
            this.lblBuyerIDText.Location = new System.Drawing.Point(116, 112);
            this.lblBuyerIDText.Name = "lblBuyerIDText";
            this.lblBuyerIDText.Size = new System.Drawing.Size(0, 17);
            this.lblBuyerIDText.TabIndex = 28;
            // 
            // lblSellerIDText
            // 
            this.lblSellerIDText.AutoSize = true;
            this.lblSellerIDText.Location = new System.Drawing.Point(116, 83);
            this.lblSellerIDText.Name = "lblSellerIDText";
            this.lblSellerIDText.Size = new System.Drawing.Size(0, 17);
            this.lblSellerIDText.TabIndex = 27;
            // 
            // lblInvoiceDateText
            // 
            this.lblInvoiceDateText.AutoSize = true;
            this.lblInvoiceDateText.Location = new System.Drawing.Point(116, 53);
            this.lblInvoiceDateText.Name = "lblInvoiceDateText";
            this.lblInvoiceDateText.Size = new System.Drawing.Size(0, 17);
            this.lblInvoiceDateText.TabIndex = 26;
            // 
            // lblInvoiceIDText
            // 
            this.lblInvoiceIDText.AutoSize = true;
            this.lblInvoiceIDText.Location = new System.Drawing.Point(116, 27);
            this.lblInvoiceIDText.Name = "lblInvoiceIDText";
            this.lblInvoiceIDText.Size = new System.Drawing.Size(0, 17);
            this.lblInvoiceIDText.TabIndex = 25;
            // 
            // lblBuyerID
            // 
            this.lblBuyerID.AutoSize = true;
            this.lblBuyerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerID.Location = new System.Drawing.Point(29, 112);
            this.lblBuyerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerID.Name = "lblBuyerID";
            this.lblBuyerID.Size = new System.Drawing.Size(80, 20);
            this.lblBuyerID.TabIndex = 24;
            this.lblBuyerID.Text = "Buyer ID:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(30, 143);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(79, 20);
            this.lblOrderID.TabIndex = 23;
            this.lblOrderID.Text = "Order ID:";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.Location = new System.Drawing.Point(21, 24);
            this.lblInvoiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(88, 20);
            this.lblInvoiceID.TabIndex = 22;
            this.lblInvoiceID.Text = "Invoice ID:";
            // 
            // lblSellerID
            // 
            this.lblSellerID.AutoSize = true;
            this.lblSellerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerID.Location = new System.Drawing.Point(30, 83);
            this.lblSellerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerID.Name = "lblSellerID";
            this.lblSellerID.Size = new System.Drawing.Size(79, 20);
            this.lblSellerID.TabIndex = 21;
            this.lblSellerID.Text = "Seller ID:";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.Location = new System.Drawing.Point(7, 53);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(107, 20);
            this.lblInvoiceDate.TabIndex = 20;
            this.lblInvoiceDate.Text = "Invoice Date:";
            // 
            // btnCloseSumary
            // 
            this.btnCloseSumary.Location = new System.Drawing.Point(878, 417);
            this.btnCloseSumary.Name = "btnCloseSumary";
            this.btnCloseSumary.Size = new System.Drawing.Size(182, 39);
            this.btnCloseSumary.TabIndex = 4;
            this.btnCloseSumary.Text = "Close Summary";
            this.btnCloseSumary.UseVisualStyleBackColor = true;
            this.btnCloseSumary.Click += new System.EventHandler(this.btnCloseSumary_Click);
            // 
            // lvInoiceIDList
            // 
            this.lvInoiceIDList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvInoiceIDList.GridLines = true;
            this.lvInoiceIDList.Location = new System.Drawing.Point(961, 42);
            this.lvInoiceIDList.Name = "lvInoiceIDList";
            this.lvInoiceIDList.Size = new System.Drawing.Size(108, 361);
            this.lvInoiceIDList.TabIndex = 3;
            this.lvInoiceIDList.UseCompatibleStateImageBehavior = false;
            this.lvInoiceIDList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "InvoiceID";
            this.columnHeader1.Width = 104;
            // 
            // cbBoxInvoiceID
            // 
            this.cbBoxInvoiceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxInvoiceID.FormattingEnabled = true;
            this.cbBoxInvoiceID.Location = new System.Drawing.Point(961, 12);
            this.cbBoxInvoiceID.Name = "cbBoxInvoiceID";
            this.cbBoxInvoiceID.Size = new System.Drawing.Size(108, 24);
            this.cbBoxInvoiceID.TabIndex = 5;
            this.cbBoxInvoiceID.SelectedIndexChanged += new System.EventHandler(this.cbBoxInvoiceID_SelectedIndexChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(686, 417);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(186, 39);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // InvoiceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 474);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbBoxInvoiceID);
            this.Controls.Add(this.btnCloseSumary);
            this.Controls.Add(this.lvInoiceIDList);
            this.Controls.Add(this.grpBoxInvoiceSummaries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvoiceSummary";
            this.Text = "InvoiceSummary";
            this.Load += new System.EventHandler(this.InvoiceSummary_Load);
            this.grpBoxInvoiceSummaries.ResumeLayout(false);
            this.grpBoxPayment.ResumeLayout(false);
            this.grpBoxPayment.PerformLayout();
            this.grpBoxIdentification.ResumeLayout(false);
            this.grpBoxIdentification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxInvoiceSummaries;
        private System.Windows.Forms.GroupBox grpBoxIdentification;
        private System.Windows.Forms.Button btnCloseSumary;
        private System.Windows.Forms.ListView lvInoiceIDList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbBoxInvoiceID;
        private System.Windows.Forms.Label lblOrderIDText;
        private System.Windows.Forms.Label lblBuyerIDText;
        private System.Windows.Forms.Label lblSellerIDText;
        private System.Windows.Forms.Label lblInvoiceDateText;
        private System.Windows.Forms.Label lblInvoiceIDText;
        private System.Windows.Forms.Label lblBuyerID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblSellerID;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListView lvInvoiceInvoice;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox grpBoxPayment;
        private System.Windows.Forms.Label lblAmountPayableText;
        private System.Windows.Forms.Label lblShippingChargesText;
        private System.Windows.Forms.Label lblAmountPayable;
        private System.Windows.Forms.Label lblShippingCharges;
    }
}