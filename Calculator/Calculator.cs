using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;





namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Text;
            calculationFiguring(s);
        }

        public void calculationFiguring(string valueofbutton)
        {
            if (calculationBox.Text == "" && valueofbutton == "+" || calculationBox.Text == "" && valueofbutton == "-" || calculationBox.Text == "" && valueofbutton == "/" || calculationBox.Text == "" && valueofbutton == "*")
            {
                double foo = Double.Parse(resultBox.Text.Replace("," , ""));
                string foo2 = foo.ToString();
                calculationBox.Text = foo2;
                calculationBox.AppendText(valueofbutton);
            }
            else
            {
                calculationBox.AppendText(valueofbutton);
            }
            
        }

        private void button_Click_CE(object sender, EventArgs e)
        {
            calculationBox.ResetText();
            resultBox.ResetText();
            resultBox.AppendText("0");
        }

        private void button_Click_C(object sender, EventArgs e)
        {
            calculationBox.ResetText();
        }

        private void button_Click_Equals(object sender, EventArgs e)
        {
            Expression finalExpression = new Expression(calculationBox.Text);
            string foo =  Convert.ToString(finalExpression.Evaluate());
            double foo2 = Double.Parse(foo);
            string foo3 = foo2.ToString("#,##0");
            resultBox.ResetText();
            resultBox.AppendText(foo3);
            calculationBox.ResetText();
        }
    }
}
