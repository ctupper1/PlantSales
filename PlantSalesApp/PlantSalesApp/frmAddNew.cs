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

        public frmAddNew()
        {
            InitializeComponent();

        }

        private void plantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.plantsDBDataSet);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
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

                //Add newPlant to the database
                PlantsDB.AddNewItem(newPlant);
                this.plantsTableAdapter.FillByUserId(this.plantsDBDataSet.Plants, Session.UserId);

                this.Close();
            }
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(nameTextBox) &&
                Validator.IsPresent(descriptionTextBox) &&
                Validator.IsPresent(careDetailsTextBox) &&
                Validator.IsPresent(typeComboBox) &&
                Validator.IsPresent(sizeComboBox) &&
                Validator.IsPresent(priceTextBox) &&
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
