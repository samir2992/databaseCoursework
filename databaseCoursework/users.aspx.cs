﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace databaseCoursework
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("loginPage.aspx");

            }

            else
            {
                if (Session["type"].ToString().ToLower() == "assistant")
                {

                    Response.Redirect("changeAssistantPsw.aspx");
                }
            }
        }

    
    }
}