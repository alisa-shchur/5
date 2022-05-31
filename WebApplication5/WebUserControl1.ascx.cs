using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        private int result;
        private double result1;
        public string Result
        {
            get { return LabelResult.Text; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPlus_Click(object sender, EventArgs e)
        {
            bool n1 = int.TryParse(TextBox1.Text, out int a);
            bool n2 = int.TryParse(TextBox2.Text, out int b);
            bool n3 = double.TryParse(TextBox1.Text, out double c);
            bool n4 = double.TryParse(TextBox2.Text, out double d);
            if (n1 && n2)
            {
                result = a + b;
                LabelResult.Text = result.ToString();
            }
            else
            {
                if(n3 && n4)
                {
                    result1 = c + d;
                    LabelResult.Text = result1.ToString();
                }
                else
                {
                    LabelResult.Text = ("Please enter a number");
                }
            }
        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            bool n1 = int.TryParse(TextBox1.Text, out int a);
            bool n2 = int.TryParse(TextBox2.Text, out int b);
            bool n3 = double.TryParse(TextBox1.Text, out double c);
            bool n4 = double.TryParse(TextBox2.Text, out double d);
            if (n1 && n2)
            {
                if (b < 0)
                {
                    result = a + Math.Abs(b);
                    LabelResult.Text = result.ToString();
                }
                else
                {
                    result = a - b;
                    LabelResult.Text = result.ToString();
                }
            }
            else
            {
                if (n3 && n4)
                {
                    result1 = c - d;
                    LabelResult.Text = result1.ToString();
                }
                else
                {
                    LabelResult.Text = ("Please enter a number");
                }
            }

        }

        protected void ButtonUmn_Click(object sender, EventArgs e)
        {
            bool n1 = int.TryParse(TextBox1.Text, out int a);
            bool n2 = int.TryParse(TextBox2.Text, out int b);
            bool n3 = double.TryParse(TextBox1.Text, out double c);
            bool n4 = double.TryParse(TextBox2.Text, out double d);
            if (n1 && n2)
            {
                result = a * b;
                LabelResult.Text = result.ToString();
            }
            else
            {
                if (n3 && n4)
                {
                    result1 = c * d;
                    LabelResult.Text = result1.ToString();
                }
                else
                {
                    LabelResult.Text = ("Please enter a number");
                }
            }
        }

        protected void ButtonDel_Click(object sender, EventArgs e)
        {
            bool n1 = int.TryParse(TextBox1.Text, out int a);
            bool n2 = int.TryParse(TextBox2.Text, out int b);
            bool n3 = double.TryParse(TextBox1.Text, out double c);
            bool n4 = double.TryParse(TextBox2.Text, out double d);
            if (n1 && n2)
            {
                if (a == 0 || b == 0)
                {
                    LabelResult.Text = "You can't divide by zero";
                }
                else
                {
                    result = a / b;
                    LabelResult.Text = result.ToString();
                }
            }
            else
            {
                if (n3 && n4)
                {
                    result1 = c / d;
                    LabelResult.Text = result1.ToString();
                }
                else
                {
                    LabelResult.Text = ("Please enter a number");
                }
            }

        }
    }
}