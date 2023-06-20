using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantSalesApp
{
    public partial class frmRegisterUser : Form
    {
        bool isRegister;

        public frmRegisterUser(bool isRegister)
        {
            this.isRegister = isRegister;
            InitializeComponent();
            if (isRegister) this.Text = "Registration Form";
            else this.Text = "Login Form";
        }

        private void frmRegisterUser_Load(object sender, EventArgs e)
        {
            if (isRegister)
            {
                btnSubmit.Text = "Register";
            } else
            {
                btnSubmit.Text = "Login";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                if (!isRegister) user = UserDB.CheckUserLogin(txtUsername.Text, txtPassword.Text);
                else
                {
                    user.Username = txtUsername.Text;
                    user.Password = txtPassword.Text;
                    UserDB.RegisterUser(user);
                }
                if (user != null) {
                    this.DialogResult = DialogResult.OK;

                    // this throws an error? I will comment it out for now until we figure out
                    // what to do with it. Are we going to have it check for the admin ID?
                    UserDB.GetUserId(user); 
                    //Session.UserId = UserDB.GetUserId(user);                 
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Please enter a valid username and password.",
                        "User Not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
