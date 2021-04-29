using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal number1 = Convert.ToDecimal(TextBox1.Text);
            decimal number2 = Convert.ToDecimal(TextBox2.Text);
            string choice = DropDownList1.SelectedValue;

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            decimal result = service.Calculate(number1, number2, choice);

            TextBox3.Text = result.ToString();
        }
    }
}