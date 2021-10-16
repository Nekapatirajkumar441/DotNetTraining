using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Calculateinterestbt_Click(object sender, EventArgs e)
        {
            var princiap = Double.Parse(principaltext.Text);
            MessageBox.Show((princiap * ratetxt).ToString(), "we double sum");
        }
    }
}
