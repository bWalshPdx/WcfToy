﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToyClient.ServiceReference1;


namespace ToyClient
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            CalcutronClient calcutron = new CalcutronClient();

            calcutron.GetRandomValue(5);

        }

        protected void submit(object sender, EventArgs e)
        {

        }

        protected void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}