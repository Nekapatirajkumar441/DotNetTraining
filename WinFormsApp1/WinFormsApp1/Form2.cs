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
            if (string.IsNullOrEmpty(principaltext.Text) || string.IsNullOrWhiteSpace(ratetxt.Text) || string.IsNullOrWhiteSpace(pricetxt.Text))
            {
                MessageBox.Show("Please Enter Values");
            }
            else
            {
                var princiap = Double.Parse(principaltext.Text);
                var rate = Double.Parse(ratetxt.Text);
                var per = Double.Parse(pricetxt.Text);
                // MessageBox.Show((princiap * rate * (per/1200)).ToString(), "we double sum");
                var intrst = (princiap * rate * (per / 1200));
                amounttxt.Text = intrst.ToString() + princiap;
            }
                
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
