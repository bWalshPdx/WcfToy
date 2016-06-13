using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormClientToy.ServiceReference1;

namespace WebFormClientToy
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Calling the WCF Service to give me a random number:
            CalcutronClient calcutron = new CalcutronClient();

            int seed = Convert.ToInt32(TextBox1.Text);
            int randomOutput = calcutron.GetRandomValue(seed);
            Label1.Text = randomOutput.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}