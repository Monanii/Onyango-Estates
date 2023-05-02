using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Realestates
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlRegister.Visible = false;
        }

        protected void lkbRegister_Click(object sender, EventArgs e)
        {
            pnlRegister.Visible = true;
            pnlLogin.Visible = false;
        }

        protected void lkbLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible=true;
            pnlRegister.Visible=false;
        }

        string connectionString = "Server=myServerAddress;Database=myDatabase;User Id=myUsername;Password=myPassword;";
        protected void Button1_Click(object sender, EventArgs e)
        {

            string username,password;

            username = txtLoginUname.Text;
            password = txtLoginPass.Text;
            // Check if the username and password are correct
            string query = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    // Invalid username or password, show an error message
                    Lbldisplay.Text = "Invalid username or password.";
                    return;
                }
            }

            // Login successful, show a success message
            Lbldisplay.Text = "Login successful.";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtRegUsername.Text;
            string email = txtRegEmail.Text;
            string password = txtRegPass.Text;
            string confirmPassword = txtCnfPass.Text;
            if (password != confirmPassword)
            {
                // Passwords don't match, show an error message
                Lblshow.Text = "Passwords don't match.";
                return;
            }
            
        }
    }
}