using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter03Program02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;

            //input set
            //Check first input...
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Erroor");
                txtOperand1.Focus();
                return;
            }

            //Check second input...
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }

            //Process step
            answer = operand1 / operand2;
            //Display step
            txtResult.Text = operand1.ToString() + " divided by " +
                            operand2.ToString() +
                            " equals " + answer.ToString();
            txtResult.Visible = true;

        }

       

        private void btnCalc_Click(object sender, EventArgs e)
        {

            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;

            //input set
            //Check first input...
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Erroor");
                txtOperand1.Focus();
                return;
            }

            //Check second input...
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;
            }

            //Process step
            answer = operand1 / operand2;
            //Display step
            txtResult.Text = operand1.ToString() + " divided by " +
                            operand2.ToString() +
                            " equals " + answer.ToString();
            txtResult.Visible = true;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
