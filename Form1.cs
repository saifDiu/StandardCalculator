using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String selectedOperation = "";
        bool value = false;
        public Form1()
       
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void numbers(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if ((tbxinput.Text == "0") || (value))
            tbxinput.Text = "";
            value = false;
            

            if (btn.Text == ".")
            {
                if (!tbxinput.Text.Contains("."))
                    tbxinput.Text = tbxinput.Text + btn.Text;
            }
            else
                {
                    tbxinput.Text = tbxinput.Text + btn.Text;
                }
            
        }

        private void tbxinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void arithmeticOperator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(result != 0)
            {

                btnEquals.PerformClick();
                value = true;
                selectedOperation = btn.Text;
                lblshow.Text = result + " " + selectedOperation;
            }
            else
            {

            selectedOperation = btn.Text;
            result = Double.Parse(tbxinput.Text);
            tbxinput.Text = "";
            lblshow.Text = result + " " + selectedOperation;
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            lblshow.Text = "";
            switch(selectedOperation)
            {
                case "+":
                    tbxinput.Text = (result + Double.Parse(tbxinput.Text)).ToString();
                    break;
                case "-":
                    tbxinput.Text = (result - Double.Parse(tbxinput.Text)).ToString();
                    break;
                case "*":
                    tbxinput.Text = (result * Double.Parse(tbxinput.Text)).ToString();
                    break;
                case "/":
                    tbxinput.Text = (result / Double.Parse(tbxinput.Text)).ToString();
                    break;
                

                default:
                    break;
            }
            result = Double.Parse(tbxinput.Text);
            selectedOperation = "";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            tbxinput.Text = "0";
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            tbxinput.Text = "0";
            result = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tbxinput.Text = (1 / Double.Parse(tbxinput.Text)).ToString();
            result = Double.Parse(tbxinput.Text);
            selectedOperation = "";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double squareValue = Double.Parse(tbxinput.Text);
            tbxinput.Text = (squareValue * squareValue).ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            double rootValue = Double.Parse(tbxinput.Text);
            tbxinput.Text = Math.Sqrt(rootValue).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double percentValue = Double.Parse(tbxinput.Text);
            tbxinput.Text = (percentValue / 100).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double vl = Double.Parse(tbxinput.Text);
            tbxinput.Text = (-vl).ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (tbxinput.Text.Length > 0)
            {
                tbxinput.Text = tbxinput.Text.Remove(tbxinput.Text.Length - 1, 1);

            }
            if(tbxinput.Text == "")
            {
                tbxinput.Text = "0";
            }
        }
    }
}
