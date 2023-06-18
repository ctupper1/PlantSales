﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlantSalesApp
{
    public partial class frmComments : Form
    {
        public frmComments()
        {
            InitializeComponent();
        }

        // Code for default text: https://stackoverflow.com/questions/14544135/how-to-gray-out-default-text-in-textbox
        private void frmComments_Load(object sender, EventArgs e)
        {
            this.txtComment.Enter += new EventHandler(txtComment_Enter);
            this.txtComment.Leave += new EventHandler(txtComment_Leave);
            txtComment_SetText();
        }

        protected void txtComment_SetText()
        {
            this.txtComment.Text = "Add a comment...";
            txtComment.ForeColor = Color.Gray;
        }

        private void txtComment_Enter(object sender, EventArgs e)
        {
            if (txtComment.ForeColor == Color.Black)
                return;
            txtComment.Text = "";
            txtComment.ForeColor = Color.Black;
        }
        private void txtComment_Leave(object sender, EventArgs e)
        {
            if (txtComment.Text.Trim() == "")
                txtComment_SetText();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtComment.Clear();
            txtComment_SetText();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}