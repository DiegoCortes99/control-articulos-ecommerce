﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace retail_prueba
{
	public partial class Error : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			txtLabel.Text = Session["error"].ToString();
		}
	}
}