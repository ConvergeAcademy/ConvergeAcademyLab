using RegisterationModule.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RegisterationModule.DAL
{
    public class UserDAL
    {

        public void Registeration(User user)
        {
            SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("proc_userRegistration", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email", user.EmailD);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}