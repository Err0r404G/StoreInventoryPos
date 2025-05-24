using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WFAManagementPro
{
    class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }

        private readonly string connectionString = @"Data Source=VICTUS-20H5\SQLEXPRESS;Initial Catalog=ShoeStorePOS;Persist Security Info=True;User ID=sa;Password=@1812;";

        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(connectionString);
            this.Sqlcon.Open();
        }

        /* private void QueryText(string query)
         {
             this.Sqlcom = new SqlCommand(query, this.Sqlcon);
         }

         public DataSet ExecuteQuery(string sql)
         {
             try
             {
                 this.QueryText(sql);
                 this.Sda = new SqlDataAdapter(this.Sqlcom);
                 this.Ds = new DataSet();
                 this.Sda.Fill(this.Ds);
                 return this.Ds;
             }
             catch (Exception exc)
             {
                 return null;
             }
         }

         public int ExecuteUpdateQuery(string sql)
         {
             this.QueryText(sql);
             int u = this.Sqlcom.ExecuteNonQuery();
             return u;
         }
        */
        //Query Function








        //////////////////////////////////// Login Validation////////////////////////////////
        public bool ValidateUser(string username, string password, out string role)
        {
            role = string.Empty;
            string sql = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    role = reader["Role"].ToString();
                    return true;
                }
            }
            return false;
        }




        ///////////////////////////////////////User CRUD Query//////////////////////////////
        //Create User
        public int InsertUser(string username, string password, string fullname, string role)
        {
            string sql = "INSERT INTO Users (Username, Password,Fullname,Role) VALUES (@username, @password,@fullname,@role)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@role", role);

            return cmd.ExecuteNonQuery();
        }

        //Update User

        public int UpdateUser(string username, string fullname, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Fullname = @fullname, Password = @Password, Role = @Role WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Fullname", fullname);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Role", role);


                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //Delete User

        public int DeleteUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        ///////////////////////////////////////Product CRUD Query /////////////////////////////
        //Create Product

        public int InsertProduct(string productname, double cost, double price, int quantity, string size)
        {
            string sql = "INSERT INTO Product (ProductName, Cost, Price, Quantity, Size) VALUES (@Productname, @Cost, @Price, @Quantity, @Size)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@ProductName", productname);
            cmd.Parameters.AddWithValue("@Cost", cost);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@Size", size);

            return cmd.ExecuteNonQuery();
        }

        //Update Product
        public int UpdateProduct(string productID, string productname, string cost, string price, string quantity, string size)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Product SET ProductName = @productname, Cost = @cost, Price = @price, Quantity = @quantity, Size = @size WHERE ProductID = @productID";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@ProductID", int.Parse(productID));
                cmd.Parameters.AddWithValue("@ProductName",productname);
                cmd.Parameters.AddWithValue("@Cost", double.Parse(cost));
                cmd.Parameters.AddWithValue("@Price", double.Parse(price));
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(quantity));
                cmd.Parameters.AddWithValue("@Size", int.Parse(size));

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        //Delete Product

        public int DeleteProduct(string productID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Product WHERE ProductID = @productID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductID", int.Parse(productID));
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        //Create Promo
        public int InsertCode(string code, string discountpercent)
        {
            string sql = "INSERT INTO PromoCode (Code, DiscountPercent) VALUES (@Code, @discountpercent)";
            SqlCommand cmd = new SqlCommand(sql, this.Sqlcon);

            cmd.Parameters.AddWithValue("@Code", code);
            cmd.Parameters.AddWithValue("@discountpercent", discountpercent);

            return cmd.ExecuteNonQuery();
        }
        
        //Delete Promo

        public int DeletePromoCode(string code)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PromoCode WHERE Code = @code";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@code", code);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        ///////////////////////////////////////Admin Search Query//////////////////////////////

        //SearchByUsername
        public DataTable SearchUsersByUsername(string username)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Username,Password, Fullname, Role FROM Users WHERE Username LIKE @username";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@username", "%" + username + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        ///////////////////////////////////////Manager Search Query//////////////////////////////

        //SearchByProductname

        public DataTable SearchByProductname(string productname)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Cost, Price,(Price - Cost) AS Profit, Quantity, Size FROM Product  WHERE ProductName LIKE @Productname";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Productname", "%" + productname + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        //SearchByPromoCode
        public DataTable SearchByPromoCode(string code)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PromoCode WHERE Code LIKE @code";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            {
                cmd.Parameters.AddWithValue("@Code", "%" + code + "%");

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        ///////////////////////////////////////Get Query//////////////////////////////

        // Get all users (ADMIN))
        public DataTable getUser()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Users";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }
        public DataTable getPromo()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM PromoCode";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        //Product Without Profit
        public DataTable getProducts()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Product";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        //Product With Profit
        public DataTable getProduct()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT ProductID,ProductName, Cost, Price,(Price - Cost) AS Profit, Quantity, Size FROM Product";

            using (SqlCommand cmd = new SqlCommand(query, this.Sqlcon))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }

            return dataTable;
        }




    }
}
