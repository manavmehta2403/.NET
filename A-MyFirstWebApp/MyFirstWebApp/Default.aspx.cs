﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnOk_Click(object sender, EventArgs e)
        {
            string firstName = TxtFirstName.Text;
            string lastname = TxtLastName.Text;

            string result = "Hello " + firstName + " " + lastname;

            LblResult.Text = result;
        }
    }
}