// Lindsay Allen (Jackson)
// CIS162AD #31778
// 4/19/21
// Meal Plan Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dorm_and_Meal_Plan_Calculator
{
    public partial class subtotalForm : Form
    {
        public subtotalForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
