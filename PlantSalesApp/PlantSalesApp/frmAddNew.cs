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
    public partial class frmAddNew : Form
    {
        public Plant plant;

        public frmAddNew(int userId)
        {
            InitializeComponent();

        }

        private void plantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plantsDBDataSet);

        }

        private void frmAddNew_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                DateTime dateAdded = DateTime.Now;
                Plant newPlant = new Plant();
                //Assign all values from this form's controls to newPlant
                newPlant.Name = nameTextBox.Text;
                newPlant.Type = typeComboBox.Text;
                newPlant.Size = sizeComboBox.Text;
                newPlant.Price = Convert.ToDecimal(priceTextBox.Text);
                newPlant.Colors = "Green";
                newPlant.Description = descriptionTextBox.Text;
                newPlant.Availability = "In Stock";
                newPlant.CareDetails = careDetailsTextBox.Text;
                newPlant.CareDifficulty = (int)careDifficultyNumericUpDown.Value;
                newPlant.UserID = Session.UserId;

                // set user to return on dialog close
                plant = newPlant;

                //Add newPlant to the database
                PlantsDB.AddNewItem(newPlant);

                // I'm still not sure which method is best to use here. The method above seems simpler but doesn't use the dataset. Should we eliminate the dataset entirely?
                // 
                //plantsTableAdapter.Insert(newPlant.Name, newPlant.Type, newPlant.Size, newPlant.Price, newPlant.Colors, newPlant.Description, newPlant.Availability, newPlant.CareDetails, newPlant.CareDifficulty, dateAdded, newPlant.UserID);


                this.Close();
            }
            else
            {
                MessageBox.Show("Please check your entry and try again.");
            }
        }

        private bool IsValidData()
        {
            // this works, but it closes the form if a field is missing? Not too sure if we want that
            if (Validator.IsPresent(nameTextBox) &&
                Validator.IsPresent(typeComboBox) &&
                Validator.IsPresent(sizeComboBox) &&
                Validator.IsPresent(priceTextBox) &&
                Validator.IsPresent(descriptionTextBox) &&
                Validator.IsPresent(careDetailsTextBox) &&
                Validator.IsDecimal(priceTextBox))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
