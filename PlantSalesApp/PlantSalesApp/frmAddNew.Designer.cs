namespace PlantSalesApp
{
    partial class frmAddNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label careDetailsLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label careDifficultyLabel;
            this.plantsDBDataSet = new PlantSalesApp.PlantsDBDataSet();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantsTableAdapter = new PlantSalesApp.PlantsDBDataSetTableAdapters.PlantsTableAdapter();
            this.tableAdapterManager = new PlantSalesApp.PlantsDBDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.careDetailsTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.careDifficultyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            careDetailsLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            careDifficultyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.careDifficultyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(8, 32);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 55);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // careDetailsLabel
            // 
            careDetailsLabel.AutoSize = true;
            careDetailsLabel.Location = new System.Drawing.Point(8, 118);
            careDetailsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            careDetailsLabel.Name = "careDetailsLabel";
            careDetailsLabel.Size = new System.Drawing.Size(67, 13);
            careDetailsLabel.TabIndex = 4;
            careDetailsLabel.Text = "Care Details:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(43, 183);
            typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(34, 13);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Type:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(165, 184);
            sizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 8;
            sizeLabel.Text = "Size:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(286, 184);
            priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 10;
            priceLabel.Text = "Price:";
            // 
            // careDifficultyLabel
            // 
            careDifficultyLabel.AutoSize = true;
            careDifficultyLabel.Location = new System.Drawing.Point(8, 211);
            careDifficultyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            careDifficultyLabel.Name = "careDifficultyLabel";
            careDifficultyLabel.Size = new System.Drawing.Size(75, 13);
            careDifficultyLabel.TabIndex = 12;
            careDifficultyLabel.Text = "Care Difficulty:";
            // 
            // plantsDBDataSet
            // 
            this.plantsDBDataSet.DataSetName = "PlantsDBDataSet";
            this.plantsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.plantsDBDataSet;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlantsTableAdapter = this.plantsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PlantSalesApp.PlantsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(79, 32);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(311, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Tag = "Name";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(79, 55);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(311, 60);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.Tag = "Description";
            // 
            // careDetailsTextBox
            // 
            this.careDetailsTextBox.Location = new System.Drawing.Point(79, 118);
            this.careDetailsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.careDetailsTextBox.Multiline = true;
            this.careDetailsTextBox.Name = "careDetailsTextBox";
            this.careDetailsTextBox.Size = new System.Drawing.Size(311, 60);
            this.careDetailsTextBox.TabIndex = 5;
            this.careDetailsTextBox.Tag = "Care Details";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Succulent",
            "Air Plant",
            "Flowering",
            "Edible Plant"});
            this.typeComboBox.Location = new System.Drawing.Point(79, 181);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(82, 21);
            this.typeComboBox.TabIndex = 7;
            this.typeComboBox.Tag = "Type";
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.sizeComboBox.Location = new System.Drawing.Point(199, 181);
            this.sizeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(82, 21);
            this.sizeComboBox.TabIndex = 9;
            this.sizeComboBox.Tag = "Size";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(322, 182);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(68, 20);
            this.priceTextBox.TabIndex = 11;
            this.priceTextBox.Tag = "Price";
            // 
            // careDifficultyNumericUpDown
            // 
            this.careDifficultyNumericUpDown.Location = new System.Drawing.Point(86, 211);
            this.careDifficultyNumericUpDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.careDifficultyNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.careDifficultyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.careDifficultyNumericUpDown.Name = "careDifficultyNumericUpDown";
            this.careDifficultyNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.careDifficultyNumericUpDown.TabIndex = 13;
            this.careDifficultyNumericUpDown.Tag = "Care Difficulty";
            this.careDifficultyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(11, 242);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(90, 31);
            this.btnAccept.TabIndex = 14;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(405, 292);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(careDifficultyLabel);
            this.Controls.Add(this.careDifficultyNumericUpDown);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeComboBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(careDetailsLabel);
            this.Controls.Add(this.careDetailsTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddNew";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.frmAddNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.careDifficultyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlantsDBDataSet plantsDBDataSet;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private PlantsDBDataSetTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private PlantsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox careDetailsTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.NumericUpDown careDifficultyNumericUpDown;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}