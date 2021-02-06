using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1Pound_To_Kilogram_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtResult.Text = "";

            radKg.Checked = false;
            radLb.Checked = false;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(txtInput.Text);
            double result = 0.0;

            if (radKg.Checked)
            {
                result = input * 0.453592;
            }
            else
            if (radLb.Checked)
            {
                result = input * 2.20462262;
            }

            txtResult.Text = result.ToString("#.#");
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
