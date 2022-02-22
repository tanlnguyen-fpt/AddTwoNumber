using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTwoNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double result;
            double num1 = 0;
            double num2 = 0;
            try
            {
                num1 = double.Parse(txtNumber1.Text);
                num2 = double.Parse(txtNumber2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a double number\n" + ex.Message);
            }
            result = num1 + num2;
            txtResult.Text = result.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                txtNumber2.Focus();
        }

        private void txtNumber2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                btnSum_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumber1.Select();
        }
    }
}
