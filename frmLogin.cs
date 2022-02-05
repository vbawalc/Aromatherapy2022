using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.DataSetExtensions;

namespace Aromatherapy_Master
{
    
    public partial class frmLogin : Form
    {
        public static String logged;
        public static String loggedrole;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Aromatherapy2;Integrated Security=True");
            string CmdString = "SELECT Login, Password, Type, UserID FROM Users WHERE login = @parameter1 AND password=@parameter2";
            SqlCommand com = new SqlCommand(CmdString,con);
            com.Parameters.Add(new SqlParameter("parameter1", txtUsername.Text));
            com.Parameters.Add(new SqlParameter("parameter2", txtPassword.Text));
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            
            if  (dtbl.Rows.Count == 1)
            {
                String Role = dtbl.Rows[0]["Type"].ToString();
                loggedrole = Role;
                if (Role == "Admin")
                {
                    frmAdmin objfrmAdmin = new frmAdmin();
                    this.Hide();
                    objfrmAdmin.Show();
                    logged = dtbl.Rows[0]["UserID"].ToString();
                    loggedrole = dtbl.Rows[0]["Type"].ToString();

                }
                else
                {
                    frmMain objFrmMain = new frmMain();
                    this.Hide();
                    objFrmMain.Show();
                    logged = dtbl.Rows[0]["UserID"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            con.Close();
             
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text="";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text="";
            }
        }
    }
}
