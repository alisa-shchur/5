using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class lab5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLab51_Click(object sender, EventArgs e)
        {
            Response.Redirect("Calculator.aspx");
        }

        protected void ButtonLab52_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lab52.aspx");
        }
    }
}