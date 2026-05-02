using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net.DAL
{
    public class DBManager
    {
        SqlConnection _connection;
        SqlCommand cmd;

        public DBManager()
        {
            _connection = new("Server=. ; Database=pubs ; TrustServerCertificate = true ; Integrated Security = true ");
            cmd = new SqlCommand();
            cmd.Connection = _connection;

        }

        public DataTable GetAllAuthors()
        {

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from authors";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;


            adapter.Fill(dt);

            return dt;
        }

        public int InsertAuthor(string auId, string lname, string fname, string phone,
                string address, string city, string state, string zip, bool contract)
        {
         
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO authors VALUES (@id, @lname, @fname, @phone, @addr, @city, @state, @zip, @contract)";

            cmd.Parameters.AddWithValue("@id", auId);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@addr", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@zip", zip);
            cmd.Parameters.AddWithValue("@contract", contract);

            _connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery(); // returns 1 if successful
            _connection.Close();


            return rowsAffected;
        }


        public int DeleteAuthor(string auth_id)
        {
           
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM authors WHERE au_id = @id";
            cmd.Parameters.AddWithValue("@id", auth_id);

            _connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            _connection.Close();

            return rowsAffected;
        }


    }
}
