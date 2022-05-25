using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static void DeleteUsers(int Id)//armushaobs
        {
            cmd = new SqlCommand("DeleteUsers", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            /*SqlParameter sp = new SqlParameter();
            sp = new SqlParameter("@UserId", Id);*/
            cmd.Parameters.Add(new SqlParameter("@UserId", Id));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Account Deleted Successfully");
        }

        public static void UpdateUsers(int Id, string name, string surname, string email, string password, int age, string address, string phoneNumber)//mushaobs
        {
            cmd = new SqlCommand("UpdateUser", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@UserId", Id);
            sp[1] = new SqlParameter("@UserName", name);
            sp[2] = new SqlParameter("@UserSurname", surname);
            sp[3] = new SqlParameter("@UserEmail", email);
            sp[4] = new SqlParameter("@UserPassword", password);
            sp[5] = new SqlParameter("@UserAge", age);
            sp[6] = new SqlParameter("@UserAddress", address);
            sp[7] = new SqlParameter("@UserPhoneNumber", phoneNumber);
            cmd.Parameters.AddRange(sp);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Updated Successfully");
        }
    }
}
