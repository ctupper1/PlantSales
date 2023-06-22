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
using PlantSalesData;


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
                User user = null;
                if (!isRegister) user = UserDB.CheckUserLogin(txtUsername.Text, txtPassword.Text);
                else
                {
                    if (!UserDB.CheckIfUsernameExists(txtUsername.Text))
                    {
                        user = new User();
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;
                        UserDB.RegisterUser(user);
                    } else
                    {
                        MessageBox.Show("Please enter a different username ",
                            "Username Exists");
                    }
                }


                if (user != null) {
                    this.DialogResult = DialogResult.OK;
                    // set user in Session
                    UserDB.GetUserId(user); 
                    this.Close();
                }
                else if(!isRegister)
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
