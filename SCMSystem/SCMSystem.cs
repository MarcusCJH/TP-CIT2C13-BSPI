using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCMSystem.classes;
using System.Collections;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SCMSystem
{
    public partial class SCMSystem : Form
    {
        List<Product> ProductList = new List<Product>();

        public SCMSystem()
        {
            InitializeComponent();
        }



        private void SCMSystem_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;


            //Creating a unique ID for Order ID
            lblOrderID.Text = UniqueIDGenerator.NewId();
            // Hard code Buyer ID
            tbxBuyerIDOrder.Text = "GFS1810";
            // List View Settings to fix the width
            this.lvProduct.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvProduct_ColumnWidthChanging);
            this.lvInvoiceInvoice.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lvInvoiceInvoice_ColumnWidthChanging);
            // List view Settings to retrieve the information from database and display in the listview
            SCMDBManager.ListViewItem(lvProduct);
            SCMDBManager.FillDropDownListProductID(cbBoxOrderProductID);
            // ReadOnly controls for textbox so that no edit is allow.
            tbxSizeOrder.ReadOnly = true;
            tbxColorOrder.ReadOnly = true;
            tbxDescriptionOrder.ReadOnly = true;
            tbxQuantitiesOrder.ReadOnly = true;
            tbxExisitingUnitPriceOrder.ReadOnly = true;

        }

        // Starting Order
        // Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.lblDateTimeOrder.Text = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
        }
        // List view fix/lock width
        private void lvProduct_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //Keep the width not changed.
            e.NewWidth = this.lvProduct.Columns[e.ColumnIndex].Width;
            //Cancel the event.
            e.Cancel = true;
        }
        // Make the list of order SAX/Stream Approach
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            if (cbBoxOrderProductID.SelectedItem != null)
            {
                p.ProductID = cbBoxOrderProductID.SelectedItem.ToString();//tbxProductIDOrder.Text;
                p.Size = tbxSizeOrder.Text;
                p.Color = tbxColorOrder.Text;
                p.Description = tbxDescriptionOrder.Text;
                p.CurrentPrice = Convert.ToDouble(tbxExisitingUnitPriceOrder.Text);
                p.UnitsToOrder = int.Parse(tbxQuantitiesOrder.Text);
                ProductList.Add(p);
            }
            else
            {
                MessageBox.Show("Please insert a product to put in.");
            }
            
            

            // Reset field
            //tbxProductIDOrder.ResetText();
            tbxSizeOrder.ResetText();
            tbxColorOrder.ResetText();
            tbxDescriptionOrder.ResetText();
            tbxQuantitiesOrder.ResetText();
            tbxExisitingUnitPriceOrder.ResetText();
            cbBoxOrderProductID.Items.Remove(cbBoxOrderProductID.SelectedItem);
            cbBoxOrderProductID.ResetText();

        }
        // Generate the XML File 
        private void btnGenerator_Click(object sender, EventArgs e)
        {

            string date = lblDateTimeOrder.Text;
            string buyerid = tbxBuyerIDOrder.Text;
            string orderid = lblOrderID.Text;
            string remark = tbxRemark.Text;

            // Create the XML File

            XmlWriterSettings setting = new XmlWriterSettings();

            
            setting.Indent = true;
            XmlWriter wrt = XmlWriter.Create(@"C:\Users\Marcus\Desktop\Dropbox\BSPI Assignment 2\GeorgeSCM XML\Order.xml", setting);

            wrt.WriteStartDocument();
            wrt.WriteStartElement("Orders");
            wrt.WriteStartElement("Order");
            wrt.WriteAttributeString("OrderId", orderid);
            wrt.WriteElementString("BuyerId", buyerid);
            wrt.WriteElementString("OrderDate", date);
            wrt.WriteElementString("Instruction", remark);
            foreach (Product p in ProductList)
            {

                wrt.WriteStartElement("Item");
                wrt.WriteAttributeString("ItemId", p.ProductID);
                wrt.WriteElementString("Size", p.Size);
                wrt.WriteElementString("Color", p.Color);
                wrt.WriteElementString("Description", p.Description);
                wrt.WriteElementString("Quantity", p.UnitsToOrder.ToString());
                wrt.WriteElementString("AskingPrice", p.CurrentPrice.ToString());
                wrt.WriteEndElement();
            }

            //close the file
            wrt.WriteEndElement();
            wrt.WriteEndDocument();
            wrt.Flush();
            
            
            wrt.Close();

            MessageBox.Show("Order submitted", "Submit");



        }
        // Search for Product ID
        private void cbBoxOrderProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbBoxOrderProductID.SelectedItem.ToString();
            Product p = SCMDBManager.GetProductByID(id);
            tbxSizeOrder.Text = p.Size;
            int UnitsToOrder = p.UnitsToOrder;
            tbxQuantitiesOrder.Text = UnitsToOrder.ToString();
            tbxDescriptionOrder.Text = p.Description;
            double currentPrice = p.CurrentPrice;
            tbxExisitingUnitPriceOrder.Text = currentPrice.ToString();
            tbxColorOrder.Text = p.Color;
        }
        /*private void btnProductIdSearchOrder_Click(object sender, EventArgs e)
        {
            
            string id = tbxProductIDOrder.Text;
            Product p = SCMDBManager.GetProductByID(id);
            tbxSizeOrder.Text = p.Size;
            int UnitsToOrder = p.UnitsToOrder;
            tbxQuantitiesOrder.Text = UnitsToOrder.ToString();
            tbxDescriptionOrder.Text = p.Description;
            double currentPrice = p.CurrentPrice;
            tbxExisitingUnitPriceOrder.Text = currentPrice.ToString();
            tbxColorOrder.Text = p.Color;
        }*/

        // Refresh Listview at List View Product
        private void btnRefreshOrderLV_Click(object sender, EventArgs e)
        {
            lvProduct.Items.Clear();
            SCMDBManager.ListViewItem(lvProduct);

        }


        // Starting Invoice
        private void btnInvoiceSummaries_Click(object sender, EventArgs e)
        {
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            invoiceSummary.Show();
        }

        // File Directory
        private void btnBrowseInvoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "XML documents (*.xml)|*.xml|All Files|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Now Display the file filename in the textbox
                tbxFilePathInvoice.Text = dlg.FileName;
            }
        }
        // Check XML Validation
        public static string checkValidation(string schemaPath, string xmlPath)
        {
            string message = "";
            XmlReaderSettings st = new XmlReaderSettings();
            st.ValidationType = ValidationType.Schema;
            st.Schemas.Add(null, schemaPath);

            st.ValidationEventHandler += (obj, e) =>
            {
                message = Convert.ToString(e.Exception);
            };

            XmlReader reader = XmlReader.Create(xmlPath, st);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    reader.Read();
                }
            }
            reader.Close();
            return message;
        }
        // Open Invoice DOM Approach
        private void btnOpenInvoice_Click(object sender, EventArgs e)
        {
            string filePath = tbxFilePathInvoice.Text;
            string schemaPath = @"C:\Users\Marcus\Desktop\SCMSystem\SCMSystem\Schema\InvoiceSchema.xsd";
            lvInvoiceInvoice.Items.Clear();
            string message = checkValidation(schemaPath, filePath);
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                XmlDocument invoiceDoc = new XmlDocument();

                // Load Xml Document

                if (!string.IsNullOrEmpty(tbxFilePathInvoice.Text))
                {

                    invoiceDoc.Load(filePath);

                    // For invoice table
                    XmlNodeList xmlInvoice = invoiceDoc.GetElementsByTagName("Invoice");
                    for (int i = 0; i < xmlInvoice.Count; i++)
                    {
                        if (xmlInvoice[i].Attributes.Count > 0)
                        {
                            lblInvoiceIDText.Text = xmlInvoice[i].Attributes[0].Value;
                        }
                        if (xmlInvoice[i].HasChildNodes)
                        {
                            XmlElement childNode = (XmlElement)xmlInvoice[i].FirstChild;
                            for (int x = 0; x < xmlInvoice[i].ChildNodes.Count; x++)
                            {
                                if (childNode.Name.Equals("InvoiceDate"))
                                {
                                    lblInvoiceDateText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("OrderID"))
                                {
                                    lblOrderIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("SellerID"))
                                {
                                    lblSellerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("BuyerID"))
                                {
                                    lblBuyerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("ShippingCharges"))
                                {
                                    lblShippingChargesInvoiceText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("TotalCostOfInvoice"))
                                {
                                    lblAmountPayableInvoiceText.Text = childNode.InnerText;
                                }
                                childNode = (XmlElement)childNode.NextSibling;
                            }
                        }
                    }
                    // For InvoiceItem Table
                    XmlNodeList xmlInvoiceItem = invoiceDoc.GetElementsByTagName("Item");
                    for (int i = 0; i < xmlInvoiceItem.Count; i++)
                    {
                        ListViewItem invoiceItem = null;
                        if (xmlInvoiceItem[i].Attributes.Count > 0)
                        {
                            invoiceItem = new ListViewItem(xmlInvoiceItem[i].Attributes[0].Value);
                        }
                        if (xmlInvoiceItem[i].HasChildNodes)
                        {
                            XmlElement itemNode = (XmlElement)xmlInvoiceItem[i].FirstChild;
                            for (int j = 0; j < xmlInvoiceItem[i].ChildNodes.Count; j++)
                            {
                                if (itemNode.Name.Equals("Size"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Color"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Description"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Quantity"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("UnitPrice"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                itemNode = (XmlElement)itemNode.NextSibling;
                            }
                        }
                        lvInvoiceInvoice.Items.Add(invoiceItem);

                    }
                }
                else
                {
                    MessageBox.Show("Please browse for an invoice file");
                }
            }
        }

        // Store Invoice into Database
        private void btnStoreDatabaseInvoice_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lblInvoiceIDText.Text))
            {
                MessageBox.Show("Are you missing out an invoice?");

            }
            else
            {

                if (MessageBox.Show("Are you sure You want to store this into database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // user clicked yes
                    int quantityInvoice = 0;
                    double unitPriceInvoice = 0.0;
                    double itemsTotalPriceInvoice = 0.0;
                    string productId = "";


                    //Invoice
                    Invoice invoice = new Invoice();

                    invoice.InvoiceID = lblInvoiceIDText.Text;
                    invoice.InvoiceDate = lblInvoiceDateText.Text;
                    invoice.OrderID = lblOrderIDText.Text;
                    invoice.SellerID = lblSellerIDText.Text;


                    for (int i = 0; i < lvInvoiceInvoice.Items.Count; i++)
                    {
                        quantityInvoice = Convert.ToInt32(lvInvoiceInvoice.Items[i].SubItems[4].Text);
                        unitPriceInvoice = Convert.ToDouble(lvInvoiceInvoice.Items[i].SubItems[5].Text);
                        itemsTotalPriceInvoice += quantityInvoice * unitPriceInvoice;
                    }
                    invoice.ShippingCharges = Convert.ToDouble(lblShippingChargesInvoiceText.Text);
                    invoice.ItemsTotalPrice = Convert.ToDouble(itemsTotalPriceInvoice);
                    invoice.InvoiceTotal = Convert.ToDouble(lblAmountPayableInvoiceText.Text);
                    SCMDBManager.insertInvoice(invoice);

                    //InvoiceItem
                    int newStockOnHand = 0;
                    int unitsOnHand = 0;
                    int quantityInvoiceItem = 0;
                    double unitPriceInvoiceItem = 0.0;
                    InvoiceItem invoiceItem = new InvoiceItem();
                    for (int i = 0; i < lvInvoiceInvoice.Items.Count; i++)
                    {
                        invoiceItem.InvoiceID = lblInvoiceIDText.Text;
                        invoiceItem.ProductID = lvInvoiceInvoice.Items[i].SubItems[0].Text;
                        invoiceItem.Size = lvInvoiceInvoice.Items[i].SubItems[1].Text;
                        invoiceItem.Color = lvInvoiceInvoice.Items[i].SubItems[2].Text;
                        invoiceItem.Description = lvInvoiceInvoice.Items[i].SubItems[3].Text;
                        invoiceItem.Quantity = Convert.ToInt32(lvInvoiceInvoice.Items[i].SubItems[4].Text);
                        invoiceItem.UnitPrice = Convert.ToDouble(lvInvoiceInvoice.Items[i].SubItems[5].Text);
                        quantityInvoiceItem = Convert.ToInt32(lvInvoiceInvoice.Items[i].SubItems[4].Text);
                        unitPriceInvoiceItem = Convert.ToDouble(lvInvoiceInvoice.Items[i].SubItems[5].Text);
                        invoiceItem.TotalPrice = Convert.ToDouble(quantityInvoiceItem * unitPriceInvoice);

                        SCMDBManager.insertInvoiceItem(invoiceItem);

                        // Apply business logic
                        quantityInvoiceItem = Convert.ToInt32(lvInvoiceInvoice.Items[i].SubItems[4].Text); // temp storage stored
                        productId = lvInvoiceInvoice.Items[i].SubItems[0].Text; // temp storage stored
                        unitsOnHand = SCMDBManager.GetProductUnitOnHandByID(productId);
                        newStockOnHand = unitsOnHand + quantityInvoiceItem;
                        SCMDBManager.updateProduct(productId, newStockOnHand);
                    }
                }
                else
                {
                    // user clicked no
                }
            }
        }
        // Lock the width for ListView Invoice Invoice
        private void lvInvoiceInvoice_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            //Keep the width not changed.
            e.NewWidth = this.lvInvoiceInvoice.Columns[e.ColumnIndex].Width;
            //Cancel the event.
            e.Cancel = true;
        }

        private void btnSupplier1Read_Click(object sender, EventArgs e)
        {
            lvInvoiceInvoice.Items.Clear();
            string filePath = @"C:\Users\Marcus\Desktop\Dropbox\BSPI Assignment 2\Supplier 1 XML\Invoice1.Xml";
            string schemaPath = @"C:\Users\Marcus\Desktop\SCMSystem\SCMSystem\Schema\InvoiceSchema.xsd";
            lvInvoiceInvoice.Items.Clear();
            string message = checkValidation(schemaPath, filePath);
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                XmlDocument invoiceDoc = new XmlDocument();
                // Load Xml Document
                if (File.Exists(filePath))
                {
                    invoiceDoc.Load(filePath);
                    // For invoice table
                    XmlNodeList xmlInvoice = invoiceDoc.GetElementsByTagName("Invoice");
                    for (int i = 0; i < xmlInvoice.Count; i++)
                    {
                        if (xmlInvoice[i].Attributes.Count > 0)
                        {
                            lblInvoiceIDText.Text = xmlInvoice[i].Attributes[0].Value;
                        }
                        if (xmlInvoice[i].HasChildNodes)
                        {
                            XmlElement childNode = (XmlElement)xmlInvoice[i].FirstChild;
                            for (int x = 0; x < xmlInvoice[i].ChildNodes.Count; x++)
                            {
                                if (childNode.Name.Equals("InvoiceDate"))
                                {
                                    lblInvoiceDateText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("OrderID"))
                                {
                                    lblOrderIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("SellerID"))
                                {
                                    lblSellerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("BuyerID"))
                                {
                                    lblBuyerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("ShippingCharges"))
                                {
                                    lblShippingChargesInvoiceText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("TotalCostOfInvoice"))
                                {
                                    lblAmountPayableInvoiceText.Text = childNode.InnerText;
                                }
                                childNode = (XmlElement)childNode.NextSibling;
                            }
                        }
                    }
                    // For InvoiceItem Table
                    XmlNodeList xmlInvoiceItem = invoiceDoc.GetElementsByTagName("Item");
                    for (int i = 0; i < xmlInvoiceItem.Count; i++)
                    {
                        ListViewItem invoiceItem = null;
                        if (xmlInvoiceItem[i].Attributes.Count > 0)
                        {
                            invoiceItem = new ListViewItem(xmlInvoiceItem[i].Attributes[0].Value);
                        }
                        if (xmlInvoiceItem[i].HasChildNodes)
                        {
                            XmlElement itemNode = (XmlElement)xmlInvoiceItem[i].FirstChild;
                            for (int j = 0; j < xmlInvoiceItem[i].ChildNodes.Count; j++)
                            {
                                if (itemNode.Name.Equals("Size"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Color"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Description"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Quantity"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("UnitPrice"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                itemNode = (XmlElement)itemNode.NextSibling;
                            }
                        }
                        lvInvoiceInvoice.Items.Add(invoiceItem);

                    }

                }
                else
                {
                    MessageBox.Show("No such thing");
                }
            }
        }

        private void btnSupplier2Read_Click(object sender, EventArgs e)
        {
            lvInvoiceInvoice.Items.Clear();
            string filePath = @"C:\Users\Marcus\Desktop\Dropbox\BSPI Assignment 2\Supplier 2 XML\Invoice2.Xml";
            string schemaPath = @"C:\Users\Marcus\Desktop\SCMSystem\SCMSystem\Schema\InvoiceSchema.xsd";
            lvInvoiceInvoice.Items.Clear();
            string message = checkValidation(schemaPath, filePath);
            
            if (message != "")
            {
                MessageBox.Show(message);
            }
            else
            {
                XmlDocument invoiceDoc = new XmlDocument();
                // Load Xml Document

                if (File.Exists(filePath))
                {
                    invoiceDoc.Load(filePath);
                    // For invoice table
                    XmlNodeList xmlInvoice = invoiceDoc.GetElementsByTagName("Invoice");
                    for (int i = 0; i < xmlInvoice.Count; i++)
                    {
                        if (xmlInvoice[i].Attributes.Count > 0)
                        {
                            lblInvoiceIDText.Text = xmlInvoice[i].Attributes[0].Value;
                        }
                        if (xmlInvoice[i].HasChildNodes)
                        {
                            XmlElement childNode = (XmlElement)xmlInvoice[i].FirstChild;
                            for (int x = 0; x < xmlInvoice[i].ChildNodes.Count; x++)
                            {
                                if (childNode.Name.Equals("InvoiceDate"))
                                {
                                    lblInvoiceDateText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("OrderID"))
                                {
                                    lblOrderIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("SellerID"))
                                {
                                    lblSellerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("BuyerID"))
                                {
                                    lblBuyerIDText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("ShippingCharges"))
                                {
                                    lblShippingChargesInvoiceText.Text = childNode.InnerText;
                                }
                                if (childNode.Name.Equals("TotalCostOfInvoice"))
                                {
                                    lblAmountPayableInvoiceText.Text = childNode.InnerText;
                                }
                                childNode = (XmlElement)childNode.NextSibling;
                            }
                        }
                    }
                    // For InvoiceItem Table
                    XmlNodeList xmlInvoiceItem = invoiceDoc.GetElementsByTagName("Item");
                    for (int i = 0; i < xmlInvoiceItem.Count; i++)
                    {
                        ListViewItem invoiceItem = null;
                        if (xmlInvoiceItem[i].Attributes.Count > 0)
                        {
                            invoiceItem = new ListViewItem(xmlInvoiceItem[i].Attributes[0].Value);
                        }
                        if (xmlInvoiceItem[i].HasChildNodes)
                        {
                            XmlElement itemNode = (XmlElement)xmlInvoiceItem[i].FirstChild;
                            for (int j = 0; j < xmlInvoiceItem[i].ChildNodes.Count; j++)
                            {
                                if (itemNode.Name.Equals("Size"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Color"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Description"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("Quantity"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                if (itemNode.Name.Equals("UnitPrice"))
                                {
                                    invoiceItem.SubItems.Add(itemNode.InnerText);
                                }
                                itemNode = (XmlElement)itemNode.NextSibling;
                            }
                        }
                        lvInvoiceInvoice.Items.Add(invoiceItem);

                    }

                }
                else
                {
                    MessageBox.Show("No such thing");
                }
            }
        }
    }
}
