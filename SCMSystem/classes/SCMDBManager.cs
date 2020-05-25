using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SCMSystem.classes
{
    class SCMDBManager
    {
        
        // For Orders
        public static ArrayList GetAllProductInfo()
        {
            ArrayList result = new ArrayList();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "SELECT * FROM Product";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Product p = new Product();
                    p.ProductID = (string)dr["ProductID"];
                    p.ProductName = (string)dr["ProductName"];
                    p.Description = (string)dr["Description"];
                    p.Manufacturer = (string)dr["Manufacturer"];
                    p.Category = (string)dr["Category"];
                    p.Size = (string)dr["Size"];
                    p.Color = (string)dr["Color"];
                    p.CurrentPrice = (double)dr["CurrentPrice"];
                    p.UnitsInStock = (int)dr["UnitsInStock"];
                    p.UnitsToOrder = (int)dr["UnitsToOrder"];
                    p.ReorderLevel = (int)dr["RecorderLevel"];
                    result.Add(p);
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
        public static void ListViewItem (ListView lv)
        {

            // Listview
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "SELECT * FROM Product";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["ProductID"].ToString());
                    item.SubItems.Add(dr["UnitsInStock"].ToString());
                    item.SubItems.Add(dr["ReorderLevel"].ToString());
                    lv.Items.Add(item);

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Product GetProductByID(string id)
        {
            Product p = new Product();
            SqlConnection conn = null;
            try
            {

                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Product WHERE ProductID=@ProductID";
                comm.Parameters.AddWithValue("@ProductID", id);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    p.Description = (string)dr["Description"];
                    p.Size = (string)dr["Size"];
                    p.Color = (string)dr["Colour"];
                    p.CurrentPrice = Convert.ToDouble(dr["CurrentPrice"].ToString());
                    p.UnitsToOrder = Convert.ToInt32(dr["UnitsToOrder"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return p;
        }
        public static void FillDropDownListProductID(ComboBox cbBox)
        {           
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlDataAdapter da = new SqlDataAdapter("Select * From Product", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbBox.Items.Add(dt.Rows[i]["ProductID"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        // For Invoice
        public static bool insertInvoice(Invoice i)
        {
            bool result = false;
            int rowsAffected = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "INSERT INTO Invoice (InvoiceID, InvoiceDate, OrderID, SellerID, ItemsTotalPrice, ShippingCharges, InvoiceTotal) VALUES (@InvoiceID, @InvoiceDate, @OrderID, @SellerID, @ItemsTotalPrice, @ShippingCharges, @InvoiceTotal)";
                comm.Parameters.AddWithValue("@InvoiceID", i.InvoiceID);
                comm.Parameters.AddWithValue("@InvoiceDate", i.InvoiceDate);
                comm.Parameters.AddWithValue("@OrderID", i.OrderID);
                comm.Parameters.AddWithValue("@SellerID", i.SellerID);
                comm.Parameters.AddWithValue("@ItemsTotalPrice", i.ItemsTotalPrice);
                comm.Parameters.AddWithValue("@ShippingCharges", i.ShippingCharges);
                comm.Parameters.AddWithValue("@InvoiceTotal", i.InvoiceTotal);
                rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
            
            
        }
        public static bool insertInvoiceItem(InvoiceItem i)
        {
            bool result = false;
            int rowsAffected = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "INSERT INTO InvoiceItems (InvoiceID, ProductID, Description, Size, Colour, Quantity, UnitPrice, TotalPrice) VALUES (@InvoiceID, @ProductID, @Description, @Size, @Colour, @Quantity, @UnitPrice, @TotalPrice)";
                comm.Parameters.AddWithValue("@InvoiceID", i.InvoiceID);
                comm.Parameters.AddWithValue("@ProductID", i.ProductID);
                comm.Parameters.AddWithValue("@Description", i.Description);
                comm.Parameters.AddWithValue("@Size", i.Size);
                comm.Parameters.AddWithValue("@Colour", i.Color);
                comm.Parameters.AddWithValue("@Quantity", i.Quantity);
                comm.Parameters.AddWithValue("@UnitPrice", i.UnitPrice);
                comm.Parameters.AddWithValue("@TotalPrice", i.TotalPrice);
                rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Business Logic
        public static bool updateProduct(string ProductID, int newStockOnHand)
        {
            bool result = false;
            int rowsAffected = 0;
            SqlConnection conn = null;
            Product p = new Product();
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "UPDATE Product SET UnitsInStock = @UnitsInStock WHERE ProductID = @ProductID";
                comm.Parameters.AddWithValue("@ProductID", ProductID);
                comm.Parameters.AddWithValue("@UnitsInStock", newStockOnHand);
                rowsAffected = comm.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;

        }
        public static int GetProductUnitOnHandByID(string id)
        {
            int UnitsToOrder = 0;
            SqlConnection conn = null;
            try
            {

                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Product WHERE ProductID=@ProductID";
                comm.Parameters.AddWithValue("@ProductID", id);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    UnitsToOrder = Convert.ToInt32(dr["UnitsInStock"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return UnitsToOrder;
        }

        // Invoice Summaries Form
        public static void FillDropDownListInvoiceID(ComboBox cbBox)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlDataAdapter da = new SqlDataAdapter("Select * From Invoice", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbBox.Items.Add(dt.Rows[i]["InvoiceID"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ListViewInvoiceID(ListView lv)
        {
            // Listview
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "SELECT * FROM Invoice";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["InvoiceID"].ToString());
                    lv.Items.Add(item);

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static Invoice GetInvoiceDetailsByID(string id)
        {
            Invoice i = new Invoice();
            SqlConnection conn = null;
            try
            {

                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Invoice WHERE InvoiceID=@InvoiceID";
                comm.Parameters.AddWithValue("@InvoiceID", id);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    i.InvoiceID = (string)dr["InvoiceID"];
                    i.InvoiceDate = (string)dr["InvoiceDate"];
                    i.OrderID = (string)dr["OrderID"];
                    i.SellerID = (string)dr["SellerID"];
                    i.ItemsTotalPrice = Convert.ToDouble(dr["ItemsTotalPrice"].ToString());
                    i.ShippingCharges = Convert.ToDouble(dr["ShippingCharges"].ToString());
                    i.InvoiceTotal = Convert.ToDouble(dr["InvoiceTotal"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return i;

        }

        
        public static void ListViewInvoiceItem(ListView lv, string id)
        {
            lv.Items.Clear();
            // Listview
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=.;Initial Catalog=GeorgeSCM;User ID=sa;Password=imsa");
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                conn.Open();
                comm.CommandText = "SELECT * FROM InvoiceItems WHERE InvoiceID = @InvoiceID";
                comm.Parameters.AddWithValue("@InvoiceID", id);
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {

                    ListViewItem item = new ListViewItem(dr["ProductID"].ToString());
                    item.SubItems.Add(dr["Size"].ToString());
                    item.SubItems.Add(dr["Colour"].ToString());
                    item.SubItems.Add(dr["Description"].ToString());
                    item.SubItems.Add(dr["Quantity"].ToString());
                    item.SubItems.Add(dr["UnitPrice"].ToString());
                    lv.Items.Add(item);

                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
