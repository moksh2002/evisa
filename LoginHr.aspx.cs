﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_visa_Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = employe; server = VDILEWVPNTH516"))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM loginhr WHERE username='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "' ", sqlCon);


                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    Session["username"] = TextBox1.Text.Trim();
                    Label3.Text = "Login Sucessfull";
                    
                }
                else
                {
                    Label3.Text = "Incorrect Details";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
    }
}