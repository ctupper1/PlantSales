using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantSalesApp
{
    public partial class frmPlantWarehouse : Form
    {
        public frmPlantWarehouse()
        {
            InitializeComponent();
        }

        bool isUserLoggedIn = false;

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPlantWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'plantsDBDataSet.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.plantsDBDataSet.Plants);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            handleRegisterForm(false);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            handleRegisterForm(true);
        }

        private void handleRegisterForm(bool newUser)
        {
            if (!isUserLoggedIn)
            {
                // https://stackoverflow.com/questions/22133358/how-to-open-new-form-pass-parameter-and-return-parameter-back
                frmRegisterUser registerUserForm = new frmRegisterUser(newUser);
                DialogResult result = registerUserForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    isUserLoggedIn = true;
                    btnLogin.Text = "Log Out";
                    btnRegister.Visible = false;
                }
            }
            else
            {
                MessageBox.Show(
                        "You are now logged out.",
                        "User Logged Out");
                isUserLoggedIn = false;
                btnLogin.Text = "Log In";
                btnRegister.Visible = true;
            }
        }
    }
}
