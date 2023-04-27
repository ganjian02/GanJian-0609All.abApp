using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabAss6
{
    public partial class CurrencyConverter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtConvert.Text);
            double result = n1 * 0.15;
            lblResult.Text = n1.ToString() + " Chisese Yuan = " + result.ToString() + " Dollar";

        }
    }
}