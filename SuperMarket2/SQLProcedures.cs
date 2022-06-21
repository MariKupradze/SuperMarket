using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuperMarket2
{
    internal class SQLProcedures
    {

        public static string conn = "Data Source=DESKTOP-TMU7V7O\\SQLEXPRESS;Initial Catalog=SuperMarket;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(conn);
        public static SqlCommand cmd;
        public static SqlDataAdapter dataAdapter;


        public static void InsertUsers(string name, string surname, string email, string password, int age, string address, string phoneNumber)
        {
            cmd = new SqlCommand("InsertUsers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@UserName", name);
            sp[1] = new SqlParameter("@UserSurname", surname);
            sp[2] = new SqlParameter("@UserEmail", email);
            sp[3] = new SqlParameter("@UserPassword", password);
            sp[4] = new SqlParameter("@UserAge", age);
            sp[5] = new SqlParameter("@UserAddress", address);
            sp[6] = new SqlParameter("@UserPhoneNumber", phoneNumber);
            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Registered Successfully");
        }


        public static DataTable SelectUsers()
        {
            cmd = new SqlCommand("SelectUsers", connection);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            return table;
        }

        public static void DeleteUsers(int Id)
        {
            cmd = new SqlCommand("DeleteUsers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = new SqlParameter();
            sp = new SqlParameter("@UserId", SqlDbType.Int);
            sp.Value = Id;
            
            cmd.Parameters.Add(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Account Deleted Successfully");
        }

        public static void UpdateUsers(int Id, string name, string surname, string password, int age, string address, string phoneNumber)//mushaobs
        {
            cmd = new SqlCommand("UpdateUsers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@UserId", Id);
            sp[1] = new SqlParameter("@UserName", name);
            sp[2] = new SqlParameter("@UserSurname", surname);
            sp[3] = new SqlParameter("@UserPassword", password);
            sp[4] = new SqlParameter("@UserAge", age);
            sp[5] = new SqlParameter("@UserAddress", address);
            sp[6] = new SqlParameter("@UserPhoneNumber", phoneNumber);
            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Updated Successfully");



        }

        public static DataTable SelectProducts()
        {
            cmd = new SqlCommand("SelectProducts", connection);
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            return table;
        }

        public static void InsertProduct(string name, string summary, int price, string quantity, int image)
        {
            cmd = new SqlCommand("InsertProduct", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@ProductName", name);
            sp[1] = new SqlParameter("@ProductSummary", summary);
            sp[2] = new SqlParameter("@ProductPrice", price);
            sp[3] = new SqlParameter("@ProductQuantity", quantity);
            sp[4] = new SqlParameter("@ProductImage", image);

            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product Added Successfully");
        }

        public static void DeleteProducts(int Id)
        {
            cmd = new SqlCommand("DeleteProducts", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = new SqlParameter();
            sp = new SqlParameter("@ProductID", SqlDbType.Int);
            sp.Value = Id;

            cmd.Parameters.Add(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product Deleted Successfully");
        }

        public static void UpdateProducts(int Id, string name, string summary, int price, string quantity, int image)
        {
            cmd = new SqlCommand("UpdateProduct", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[7];
            sp[0] = new SqlParameter("@ProductID", Id);
            sp[1] = new SqlParameter("@ProductName", name);
            sp[2] = new SqlParameter("@ProductSummary", summary);
            sp[3] = new SqlParameter("@ProductPrice", price);
            sp[4] = new SqlParameter("@ProductQuantity", quantity);
            sp[5] = new SqlParameter("@ProductImage", image);
            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Product Updated Successfully");

        }

        public static void ChangeQuantity(int Id, int change)
        {
            cmd = new SqlCommand("UpdateProduct", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@ProductID", Id);
            sp[1] = new SqlParameter("@Quantitychange", change);
            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}
