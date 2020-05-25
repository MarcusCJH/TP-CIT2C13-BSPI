namespace SCMSystem
{
    partial class SCMSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SCMSystem));
            this.tabSCM = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefreshOrderLV = new System.Windows.Forms.Button();
            this.grpBxOrder = new System.Windows.Forms.GroupBox();
            this.tbxRemark = new System.Windows.Forms.TextBox();
            this.grpBoxOrder2 = new System.Windows.Forms.GroupBox();
            this.cbBoxOrderProductID = new System.Windows.Forms.ComboBox();
            this.grpBoxOrder3 = new System.Windows.Forms.GroupBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tbxExisitingUnitPriceOrder = new System.Windows.Forms.TextBox();
            this.tbxQuantitiesOrder = new System.Windows.Forms.TextBox();
            this.tbxDescriptionOrder = new System.Windows.Forms.TextBox();
            this.tbxColorOrder = new System.Windows.Forms.TextBox();
            this.tbxSizeOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemarksOrder = new System.Windows.Forms.Label();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.lvProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUnitInStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRecorderLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxBuyerIDOrder = new System.Windows.Forms.TextBox();
            this.lblDateTimeOrder = new System.Windows.Forms.Label();
            this.lblBuyerIDOrder = new System.Windows.Forms.Label();
            this.lblDateOrder = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSupplier2Read = new System.Windows.Forms.Button();
            this.btnSupplier1Read = new System.Windows.Forms.Button();
            this.lvInvoiceInvoice = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenInvoice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAmountPayableInvoiceText = new System.Windows.Forms.Label();
            this.lblShippingChargesInvoiceText = new System.Windows.Forms.Label();
            this.lblAmountPayableInvoice = new System.Windows.Forms.Label();
            this.lblShippingChargesInvoice = new System.Windows.Forms.Label();
            this.btnInvoiceSummaries = new System.Windows.Forms.Button();
            this.btnStoreDatabaseInvoice = new System.Windows.Forms.Button();
            this.grpBoxInvoiceDetailID = new System.Windows.Forms.GroupBox();
            this.lblOrderIDText = new System.Windows.Forms.Label();
            this.lblBuyerIDText = new System.Windows.Forms.Label();
            this.lblSellerIDText = new System.Windows.Forms.Label();
            this.lblInvoiceDateText = new System.Windows.Forms.Label();
            this.lblInvoiceIDText = new System.Windows.Forms.Label();
            this.lblBuyerIDInvoice = new System.Windows.Forms.Label();
            this.lblOrderIDInvoice = new System.Windows.Forms.Label();
            this.lblInvoiceIDInvoice = new System.Windows.Forms.Label();
            this.lblSellerIDInvoice = new System.Windows.Forms.Label();
            this.lblInvoideDateInvoice = new System.Windows.Forms.Label();
            this.btnBrowseInvoice = new System.Windows.Forms.Button();
            this.tbxFilePathInvoice = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsToOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.tabSCM.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBxOrder.SuspendLayout();
            this.grpBoxOrder2.SuspendLayout();
            this.grpBoxOrder3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxInvoiceDetailID.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSCM
            // 
            this.tabSCM.Controls.Add(this.tabPage1);
            this.tabSCM.Controls.Add(this.tabPage2);
            this.tabSCM.Location = new System.Drawing.Point(0, 1);
            this.tabSCM.Margin = new System.Windows.Forms.Padding(4);
            this.tabSCM.Name = "tabSCM";
            this.tabSCM.SelectedIndex = 0;
            this.tabSCM.Size = new System.Drawing.Size(1036, 542);
            this.tabSCM.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefreshOrderLV);
            this.tabPage1.Controls.Add(this.grpBxOrder);
            this.tabPage1.Controls.Add(this.lvProduct);
            this.tabPage1.Controls.Add(this.tbxBuyerIDOrder);
            this.tabPage1.Controls.Add(this.lblDateTimeOrder);
            this.tabPage1.Controls.Add(this.lblBuyerIDOrder);
            this.tabPage1.Controls.Add(this.lblDateOrder);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1028, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Make Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefreshOrderLV
            // 
            this.btnRefreshOrderLV.Location = new System.Drawing.Point(27, 455);
            this.btnRefreshOrderLV.Name = "btnRefreshOrderLV";
            this.btnRefreshOrderLV.Size = new System.Drawing.Size(363, 23);
            this.btnRefreshOrderLV.TabIndex = 9;
            this.btnRefreshOrderLV.Text = "Refresh Table";
            this.btnRefreshOrderLV.UseVisualStyleBackColor = true;
            this.btnRefreshOrderLV.Click += new System.EventHandler(this.btnRefreshOrderLV_Click);
            // 
            // grpBxOrder
            // 
            this.grpBxOrder.Controls.Add(this.tbxRemark);
            this.grpBxOrder.Controls.Add(this.grpBoxOrder2);
            this.grpBxOrder.Controls.Add(this.lblRemarksOrder);
            this.grpBxOrder.Controls.Add(this.btnGenerator);
            this.grpBxOrder.Location = new System.Drawing.Point(396, 125);
            this.grpBxOrder.Name = "grpBxOrder";
            this.grpBxOrder.Size = new System.Drawing.Size(591, 353);
            this.grpBxOrder.TabIndex = 8;
            this.grpBxOrder.TabStop = false;
            // 
            // tbxRemark
            // 
            this.tbxRemark.Location = new System.Drawing.Point(17, 299);
            this.tbxRemark.Multiline = true;
            this.tbxRemark.Name = "tbxRemark";
            this.tbxRemark.Size = new System.Drawing.Size(383, 36);
            this.tbxRemark.TabIndex = 17;
            // 
            // grpBoxOrder2
            // 
            this.grpBoxOrder2.Controls.Add(this.cbBoxOrderProductID);
            this.grpBoxOrder2.Controls.Add(this.grpBoxOrder3);
            this.grpBoxOrder2.Controls.Add(this.tbxExisitingUnitPriceOrder);
            this.grpBoxOrder2.Controls.Add(this.tbxQuantitiesOrder);
            this.grpBoxOrder2.Controls.Add(this.tbxDescriptionOrder);
            this.grpBoxOrder2.Controls.Add(this.tbxColorOrder);
            this.grpBoxOrder2.Controls.Add(this.tbxSizeOrder);
            this.grpBoxOrder2.Controls.Add(this.btnAddOrder);
            this.grpBoxOrder2.Controls.Add(this.label1);
            this.grpBoxOrder2.Controls.Add(this.label5);
            this.grpBoxOrder2.Controls.Add(this.label6);
            this.grpBoxOrder2.Controls.Add(this.label4);
            this.grpBoxOrder2.Controls.Add(this.label2);
            this.grpBoxOrder2.Controls.Add(this.label3);
            this.grpBoxOrder2.Location = new System.Drawing.Point(6, 21);
            this.grpBoxOrder2.Name = "grpBoxOrder2";
            this.grpBoxOrder2.Size = new System.Drawing.Size(579, 252);
            this.grpBoxOrder2.TabIndex = 16;
            this.grpBoxOrder2.TabStop = false;
            this.grpBoxOrder2.Text = "Add Orders";
            // 
            // cbBoxOrderProductID
            // 
            this.cbBoxOrderProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxOrderProductID.FormattingEnabled = true;
            this.cbBoxOrderProductID.Location = new System.Drawing.Point(175, 27);
            this.cbBoxOrderProductID.Name = "cbBoxOrderProductID";
            this.cbBoxOrderProductID.Size = new System.Drawing.Size(121, 24);
            this.cbBoxOrderProductID.TabIndex = 24;
            this.cbBoxOrderProductID.SelectedIndexChanged += new System.EventHandler(this.cbBoxOrderProductID_SelectedIndexChanged);
            // 
            // grpBoxOrder3
            // 
            this.grpBoxOrder3.Controls.Add(this.lblOrderID);
            this.grpBoxOrder3.Location = new System.Drawing.Point(373, 23);
            this.grpBoxOrder3.Name = "grpBoxOrder3";
            this.grpBoxOrder3.Size = new System.Drawing.Size(200, 66);
            this.grpBoxOrder3.TabIndex = 22;
            this.grpBoxOrder3.TabStop = false;
            this.grpBoxOrder3.Text = "OrderID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(58, 28);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(16, 17);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "[]";
            // 
            // tbxExisitingUnitPriceOrder
            // 
            this.tbxExisitingUnitPriceOrder.Location = new System.Drawing.Point(174, 188);
            this.tbxExisitingUnitPriceOrder.Name = "tbxExisitingUnitPriceOrder";
            this.tbxExisitingUnitPriceOrder.Size = new System.Drawing.Size(120, 22);
            this.tbxExisitingUnitPriceOrder.TabIndex = 21;
            // 
            // tbxQuantitiesOrder
            // 
            this.tbxQuantitiesOrder.Location = new System.Drawing.Point(175, 160);
            this.tbxQuantitiesOrder.Name = "tbxQuantitiesOrder";
            this.tbxQuantitiesOrder.Size = new System.Drawing.Size(120, 22);
            this.tbxQuantitiesOrder.TabIndex = 20;
            // 
            // tbxDescriptionOrder
            // 
            this.tbxDescriptionOrder.Location = new System.Drawing.Point(175, 129);
            this.tbxDescriptionOrder.Name = "tbxDescriptionOrder";
            this.tbxDescriptionOrder.Size = new System.Drawing.Size(120, 22);
            this.tbxDescriptionOrder.TabIndex = 19;
            // 
            // tbxColorOrder
            // 
            this.tbxColorOrder.Location = new System.Drawing.Point(174, 98);
            this.tbxColorOrder.Name = "tbxColorOrder";
            this.tbxColorOrder.Size = new System.Drawing.Size(120, 22);
            this.tbxColorOrder.TabIndex = 18;
            // 
            // tbxSizeOrder
            // 
            this.tbxSizeOrder.Location = new System.Drawing.Point(175, 66);
            this.tbxSizeOrder.Name = "tbxSizeOrder";
            this.tbxSizeOrder.Size = new System.Drawing.Size(120, 22);
            this.tbxSizeOrder.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Exisiting Unit Prices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantities";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decsription";
            // 
            // lblRemarksOrder
            // 
            this.lblRemarksOrder.AutoSize = true;
            this.lblRemarksOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarksOrder.Location = new System.Drawing.Point(13, 276);
            this.lblRemarksOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarksOrder.Name = "lblRemarksOrder";
            this.lblRemarksOrder.Size = new System.Drawing.Size(81, 20);
            this.lblRemarksOrder.TabIndex = 15;
            this.lblRemarksOrder.Text = "Remarks:";
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(431, 299);
            this.btnGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(148, 28);
            this.btnGenerator.TabIndex = 5;
            this.btnGenerator.Text = "Generate Order";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvProductID,
            this.lvUnitInStock,
            this.lvRecorderLevel});
            this.lvProduct.GridLines = true;
            this.lvProduct.Location = new System.Drawing.Point(27, 125);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(363, 327);
            this.lvProduct.TabIndex = 7;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvProduct_ColumnWidthChanging);
            // 
            // lvProductID
            // 
            this.lvProductID.Text = "Product ID";
            this.lvProductID.Width = 109;
            // 
            // lvUnitInStock
            // 
            this.lvUnitInStock.Text = "Unit In Stock";
            this.lvUnitInStock.Width = 121;
            // 
            // lvRecorderLevel
            // 
            this.lvRecorderLevel.Text = "Recorder Level";
            this.lvRecorderLevel.Width = 129;
            // 
            // tbxBuyerIDOrder
            // 
            this.tbxBuyerIDOrder.Location = new System.Drawing.Point(108, 31);
            this.tbxBuyerIDOrder.Margin = new System.Windows.Forms.Padding(4);
            this.tbxBuyerIDOrder.Name = "tbxBuyerIDOrder";
            this.tbxBuyerIDOrder.Size = new System.Drawing.Size(132, 22);
            this.tbxBuyerIDOrder.TabIndex = 3;
            // 
            // lblDateTimeOrder
            // 
            this.lblDateTimeOrder.AutoSize = true;
            this.lblDateTimeOrder.Location = new System.Drawing.Point(105, 10);
            this.lblDateTimeOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTimeOrder.Name = "lblDateTimeOrder";
            this.lblDateTimeOrder.Size = new System.Drawing.Size(16, 17);
            this.lblDateTimeOrder.TabIndex = 2;
            this.lblDateTimeOrder.Text = "[]";
            // 
            // lblBuyerIDOrder
            // 
            this.lblBuyerIDOrder.AutoSize = true;
            this.lblBuyerIDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerIDOrder.Location = new System.Drawing.Point(15, 33);
            this.lblBuyerIDOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerIDOrder.Name = "lblBuyerIDOrder";
            this.lblBuyerIDOrder.Size = new System.Drawing.Size(75, 20);
            this.lblBuyerIDOrder.TabIndex = 1;
            this.lblBuyerIDOrder.Text = "Buyer ID";
            // 
            // lblDateOrder
            // 
            this.lblDateOrder.AutoSize = true;
            this.lblDateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOrder.Location = new System.Drawing.Point(40, 7);
            this.lblDateOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOrder.Name = "lblDateOrder";
            this.lblDateOrder.Size = new System.Drawing.Size(50, 20);
            this.lblDateOrder.TabIndex = 0;
            this.lblDateOrder.Text = "Date:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 4);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1020, 505);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 23;
            this.lineShape1.X2 = 981;
            this.lineShape1.Y1 = 84;
            this.lineShape1.Y2 = 84;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSupplier2Read);
            this.tabPage2.Controls.Add(this.btnSupplier1Read);
            this.tabPage2.Controls.Add(this.lvInvoiceInvoice);
            this.tabPage2.Controls.Add(this.btnOpenInvoice);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnInvoiceSummaries);
            this.tabPage2.Controls.Add(this.btnStoreDatabaseInvoice);
            this.tabPage2.Controls.Add(this.grpBoxInvoiceDetailID);
            this.tabPage2.Controls.Add(this.btnBrowseInvoice);
            this.tabPage2.Controls.Add(this.tbxFilePathInvoice);
            this.tabPage2.Controls.Add(this.shapeContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1028, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSupplier2Read
            // 
            this.btnSupplier2Read.Location = new System.Drawing.Point(488, 49);
            this.btnSupplier2Read.Name = "btnSupplier2Read";
            this.btnSupplier2Read.Size = new System.Drawing.Size(207, 23);
            this.btnSupplier2Read.TabIndex = 19;
            this.btnSupplier2Read.Text = "Supplier 2";
            this.btnSupplier2Read.UseVisualStyleBackColor = true;
            this.btnSupplier2Read.Click += new System.EventHandler(this.btnSupplier2Read_Click);
            // 
            // btnSupplier1Read
            // 
            this.btnSupplier1Read.Location = new System.Drawing.Point(170, 49);
            this.btnSupplier1Read.Name = "btnSupplier1Read";
            this.btnSupplier1Read.Size = new System.Drawing.Size(207, 23);
            this.btnSupplier1Read.TabIndex = 18;
            this.btnSupplier1Read.Text = "Supplier 1";
            this.btnSupplier1Read.UseVisualStyleBackColor = true;
            this.btnSupplier1Read.Click += new System.EventHandler(this.btnSupplier1Read_Click);
            // 
            // lvInvoiceInvoice
            // 
            this.lvInvoiceInvoice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvInvoiceInvoice.GridLines = true;
            this.lvInvoiceInvoice.Location = new System.Drawing.Point(40, 99);
            this.lvInvoiceInvoice.Name = "lvInvoiceInvoice";
            this.lvInvoiceInvoice.Size = new System.Drawing.Size(715, 242);
            this.lvInvoiceInvoice.TabIndex = 17;
            this.lvInvoiceInvoice.UseCompatibleStateImageBehavior = false;
            this.lvInvoiceInvoice.View = System.Windows.Forms.View.Details;
            this.lvInvoiceInvoice.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvInvoiceInvoice_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductID";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Size";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Colour";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 173;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Unit Price";
            this.columnHeader6.Width = 113;
            // 
            // btnOpenInvoice
            // 
            this.btnOpenInvoice.Location = new System.Drawing.Point(939, 20);
            this.btnOpenInvoice.Name = "btnOpenInvoice";
            this.btnOpenInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnOpenInvoice.TabIndex = 16;
            this.btnOpenInvoice.Text = "Open";
            this.btnOpenInvoice.UseVisualStyleBackColor = true;
            this.btnOpenInvoice.Click += new System.EventHandler(this.btnOpenInvoice_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAmountPayableInvoiceText);
            this.groupBox1.Controls.Add(this.lblShippingChargesInvoiceText);
            this.groupBox1.Controls.Add(this.lblAmountPayableInvoice);
            this.groupBox1.Controls.Add(this.lblShippingChargesInvoice);
            this.groupBox1.Location = new System.Drawing.Point(40, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 96);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // lblAmountPayableInvoiceText
            // 
            this.lblAmountPayableInvoiceText.AutoSize = true;
            this.lblAmountPayableInvoiceText.Location = new System.Drawing.Point(166, 53);
            this.lblAmountPayableInvoiceText.Name = "lblAmountPayableInvoiceText";
            this.lblAmountPayableInvoiceText.Size = new System.Drawing.Size(16, 17);
            this.lblAmountPayableInvoiceText.TabIndex = 17;
            this.lblAmountPayableInvoiceText.Text = "[]";
            // 
            // lblShippingChargesInvoiceText
            // 
            this.lblShippingChargesInvoiceText.AutoSize = true;
            this.lblShippingChargesInvoiceText.Location = new System.Drawing.Point(166, 30);
            this.lblShippingChargesInvoiceText.Name = "lblShippingChargesInvoiceText";
            this.lblShippingChargesInvoiceText.Size = new System.Drawing.Size(0, 17);
            this.lblShippingChargesInvoiceText.TabIndex = 16;
            // 
            // lblAmountPayableInvoice
            // 
            this.lblAmountPayableInvoice.AutoSize = true;
            this.lblAmountPayableInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPayableInvoice.Location = new System.Drawing.Point(29, 53);
            this.lblAmountPayableInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountPayableInvoice.Name = "lblAmountPayableInvoice";
            this.lblAmountPayableInvoice.Size = new System.Drawing.Size(130, 20);
            this.lblAmountPayableInvoice.TabIndex = 16;
            this.lblAmountPayableInvoice.Text = "AmountPayable:";
            // 
            // lblShippingChargesInvoice
            // 
            this.lblShippingChargesInvoice.AutoSize = true;
            this.lblShippingChargesInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingChargesInvoice.Location = new System.Drawing.Point(8, 30);
            this.lblShippingChargesInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShippingChargesInvoice.Name = "lblShippingChargesInvoice";
            this.lblShippingChargesInvoice.Size = new System.Drawing.Size(151, 20);
            this.lblShippingChargesInvoice.TabIndex = 16;
            this.lblShippingChargesInvoice.Text = "Shipping Charges: ";
            // 
            // btnInvoiceSummaries
            // 
            this.btnInvoiceSummaries.Location = new System.Drawing.Point(761, 429);
            this.btnInvoiceSummaries.Name = "btnInvoiceSummaries";
            this.btnInvoiceSummaries.Size = new System.Drawing.Size(251, 65);
            this.btnInvoiceSummaries.TabIndex = 14;
            this.btnInvoiceSummaries.Text = "Invoice Summaries";
            this.btnInvoiceSummaries.UseVisualStyleBackColor = true;
            this.btnInvoiceSummaries.Click += new System.EventHandler(this.btnInvoiceSummaries_Click);
            // 
            // btnStoreDatabaseInvoice
            // 
            this.btnStoreDatabaseInvoice.Location = new System.Drawing.Point(761, 347);
            this.btnStoreDatabaseInvoice.Name = "btnStoreDatabaseInvoice";
            this.btnStoreDatabaseInvoice.Size = new System.Drawing.Size(251, 65);
            this.btnStoreDatabaseInvoice.TabIndex = 13;
            this.btnStoreDatabaseInvoice.Text = "Store Database";
            this.btnStoreDatabaseInvoice.UseVisualStyleBackColor = true;
            this.btnStoreDatabaseInvoice.Click += new System.EventHandler(this.btnStoreDatabaseInvoice_Click);
            // 
            // grpBoxInvoiceDetailID
            // 
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblOrderIDText);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblBuyerIDText);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblSellerIDText);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblInvoiceDateText);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblInvoiceIDText);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblBuyerIDInvoice);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblOrderIDInvoice);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblInvoiceIDInvoice);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblSellerIDInvoice);
            this.grpBoxInvoiceDetailID.Controls.Add(this.lblInvoideDateInvoice);
            this.grpBoxInvoiceDetailID.Location = new System.Drawing.Point(761, 89);
            this.grpBoxInvoiceDetailID.Name = "grpBoxInvoiceDetailID";
            this.grpBoxInvoiceDetailID.Size = new System.Drawing.Size(251, 252);
            this.grpBoxInvoiceDetailID.TabIndex = 11;
            this.grpBoxInvoiceDetailID.TabStop = false;
            this.grpBoxInvoiceDetailID.Text = "Identification";
            // 
            // lblOrderIDText
            // 
            this.lblOrderIDText.AutoSize = true;
            this.lblOrderIDText.Location = new System.Drawing.Point(116, 146);
            this.lblOrderIDText.Name = "lblOrderIDText";
            this.lblOrderIDText.Size = new System.Drawing.Size(0, 17);
            this.lblOrderIDText.TabIndex = 19;
            // 
            // lblBuyerIDText
            // 
            this.lblBuyerIDText.AutoSize = true;
            this.lblBuyerIDText.Location = new System.Drawing.Point(116, 115);
            this.lblBuyerIDText.Name = "lblBuyerIDText";
            this.lblBuyerIDText.Size = new System.Drawing.Size(0, 17);
            this.lblBuyerIDText.TabIndex = 18;
            // 
            // lblSellerIDText
            // 
            this.lblSellerIDText.AutoSize = true;
            this.lblSellerIDText.Location = new System.Drawing.Point(116, 86);
            this.lblSellerIDText.Name = "lblSellerIDText";
            this.lblSellerIDText.Size = new System.Drawing.Size(0, 17);
            this.lblSellerIDText.TabIndex = 17;
            // 
            // lblInvoiceDateText
            // 
            this.lblInvoiceDateText.AutoSize = true;
            this.lblInvoiceDateText.Location = new System.Drawing.Point(116, 56);
            this.lblInvoiceDateText.Name = "lblInvoiceDateText";
            this.lblInvoiceDateText.Size = new System.Drawing.Size(0, 17);
            this.lblInvoiceDateText.TabIndex = 16;
            // 
            // lblInvoiceIDText
            // 
            this.lblInvoiceIDText.AutoSize = true;
            this.lblInvoiceIDText.Location = new System.Drawing.Point(116, 30);
            this.lblInvoiceIDText.Name = "lblInvoiceIDText";
            this.lblInvoiceIDText.Size = new System.Drawing.Size(0, 17);
            this.lblInvoiceIDText.TabIndex = 15;
            // 
            // lblBuyerIDInvoice
            // 
            this.lblBuyerIDInvoice.AutoSize = true;
            this.lblBuyerIDInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerIDInvoice.Location = new System.Drawing.Point(29, 115);
            this.lblBuyerIDInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerIDInvoice.Name = "lblBuyerIDInvoice";
            this.lblBuyerIDInvoice.Size = new System.Drawing.Size(80, 20);
            this.lblBuyerIDInvoice.TabIndex = 14;
            this.lblBuyerIDInvoice.Text = "Buyer ID:";
            // 
            // lblOrderIDInvoice
            // 
            this.lblOrderIDInvoice.AutoSize = true;
            this.lblOrderIDInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDInvoice.Location = new System.Drawing.Point(30, 146);
            this.lblOrderIDInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderIDInvoice.Name = "lblOrderIDInvoice";
            this.lblOrderIDInvoice.Size = new System.Drawing.Size(79, 20);
            this.lblOrderIDInvoice.TabIndex = 13;
            this.lblOrderIDInvoice.Text = "Order ID:";
            // 
            // lblInvoiceIDInvoice
            // 
            this.lblInvoiceIDInvoice.AutoSize = true;
            this.lblInvoiceIDInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceIDInvoice.Location = new System.Drawing.Point(21, 27);
            this.lblInvoiceIDInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceIDInvoice.Name = "lblInvoiceIDInvoice";
            this.lblInvoiceIDInvoice.Size = new System.Drawing.Size(88, 20);
            this.lblInvoiceIDInvoice.TabIndex = 12;
            this.lblInvoiceIDInvoice.Text = "Invoice ID:";
            // 
            // lblSellerIDInvoice
            // 
            this.lblSellerIDInvoice.AutoSize = true;
            this.lblSellerIDInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerIDInvoice.Location = new System.Drawing.Point(30, 86);
            this.lblSellerIDInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerIDInvoice.Name = "lblSellerIDInvoice";
            this.lblSellerIDInvoice.Size = new System.Drawing.Size(79, 20);
            this.lblSellerIDInvoice.TabIndex = 11;
            this.lblSellerIDInvoice.Text = "Seller ID:";
            // 
            // lblInvoideDateInvoice
            // 
            this.lblInvoideDateInvoice.AutoSize = true;
            this.lblInvoideDateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoideDateInvoice.Location = new System.Drawing.Point(7, 56);
            this.lblInvoideDateInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoideDateInvoice.Name = "lblInvoideDateInvoice";
            this.lblInvoideDateInvoice.Size = new System.Drawing.Size(102, 20);
            this.lblInvoideDateInvoice.TabIndex = 10;
            this.lblInvoideDateInvoice.Text = "Invoice Date";
            // 
            // btnBrowseInvoice
            // 
            this.btnBrowseInvoice.Location = new System.Drawing.Point(858, 20);
            this.btnBrowseInvoice.Name = "btnBrowseInvoice";
            this.btnBrowseInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInvoice.TabIndex = 9;
            this.btnBrowseInvoice.Text = "Browse";
            this.btnBrowseInvoice.UseVisualStyleBackColor = true;
            this.btnBrowseInvoice.Click += new System.EventHandler(this.btnBrowseInvoice_Click);
            // 
            // tbxFilePathInvoice
            // 
            this.tbxFilePathInvoice.Location = new System.Drawing.Point(40, 21);
            this.tbxFilePathInvoice.Name = "tbxFilePathInvoice";
            this.tbxFilePathInvoice.ReadOnly = true;
            this.tbxFilePathInvoice.Size = new System.Drawing.Size(808, 22);
            this.tbxFilePathInvoice.TabIndex = 8;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(4, 4);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1020, 505);
            this.shapeContainer2.TabIndex = 12;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 36;
            this.lineShape2.X2 = 979;
            this.lineShape2.Y1 = 72;
            this.lineShape2.Y2 = 72;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitsToOrderDataGridViewTextBoxColumn
            // 
            this.unitsToOrderDataGridViewTextBoxColumn.Name = "unitsToOrderDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(425, 223);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(148, 23);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Add Orders";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // SCMSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 546);
            this.Controls.Add(this.tabSCM);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SCMSystem";
            this.Text = "Geoge Fashion Service - SCM System";
            this.Load += new System.EventHandler(this.SCMSystem_Load);
            this.tabSCM.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpBxOrder.ResumeLayout(false);
            this.grpBxOrder.PerformLayout();
            this.grpBoxOrder2.ResumeLayout(false);
            this.grpBoxOrder2.PerformLayout();
            this.grpBoxOrder3.ResumeLayout(false);
            this.grpBoxOrder3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxInvoiceDetailID.ResumeLayout(false);
            this.grpBoxInvoiceDetailID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSCM;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDateTimeOrder;
        private System.Windows.Forms.Label lblBuyerIDOrder;
        private System.Windows.Forms.Label lblDateOrder;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox tbxBuyerIDOrder;
        private System.Windows.Forms.Button btnGenerator;
        
        

        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsToOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader lvProductID;
        private System.Windows.Forms.ColumnHeader lvUnitInStock;
        private System.Windows.Forms.ColumnHeader lvRecorderLevel;
        private System.Windows.Forms.GroupBox grpBxOrder;
        private System.Windows.Forms.GroupBox grpBoxOrder2;
        private System.Windows.Forms.TextBox tbxExisitingUnitPriceOrder;
        private System.Windows.Forms.TextBox tbxQuantitiesOrder;
        private System.Windows.Forms.TextBox tbxDescriptionOrder;
        private System.Windows.Forms.TextBox tbxColorOrder;
        private System.Windows.Forms.TextBox tbxSizeOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRemarksOrder;
        private System.Windows.Forms.TextBox tbxRemark;
        private System.Windows.Forms.GroupBox grpBoxOrder3;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button btnBrowseInvoice;
        private System.Windows.Forms.TextBox tbxFilePathInvoice;
        private System.Windows.Forms.GroupBox grpBoxInvoiceDetailID;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label lblBuyerIDInvoice;
        private System.Windows.Forms.Label lblOrderIDInvoice;
        private System.Windows.Forms.Label lblInvoiceIDInvoice;
        private System.Windows.Forms.Label lblSellerIDInvoice;
        private System.Windows.Forms.Label lblInvoideDateInvoice;
        private System.Windows.Forms.Label lblOrderIDText;
        private System.Windows.Forms.Label lblBuyerIDText;
        private System.Windows.Forms.Label lblSellerIDText;
        private System.Windows.Forms.Label lblInvoiceDateText;
        private System.Windows.Forms.Label lblInvoiceIDText;
        private System.Windows.Forms.Button btnInvoiceSummaries;
        private System.Windows.Forms.Button btnStoreDatabaseInvoice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAmountPayableInvoiceText;
        private System.Windows.Forms.Label lblShippingChargesInvoiceText;
        private System.Windows.Forms.Label lblAmountPayableInvoice;
        private System.Windows.Forms.Label lblShippingChargesInvoice;
        private System.Windows.Forms.Button btnOpenInvoice;
        private System.Windows.Forms.Button btnRefreshOrderLV;
        private System.Windows.Forms.ComboBox cbBoxOrderProductID;
        private System.Windows.Forms.ListView lvInvoiceInvoice;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnSupplier2Read;
        private System.Windows.Forms.Button btnSupplier1Read;
    }
}

