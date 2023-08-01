using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_visa_Project
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection("Trusted_Connection = Yes;database = employe; server = VDILEWVPNTH516"))
            {
                if (TextBox2.Text == TextBox3.Text)
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("Insert into loginhr values('" + TextBox1.Text + "' ,'" + TextBox2.Text + "')", sqlCon);
                    
                        Session["username"] = TextBox1.Text.Trim();
                        Label5.Text = "Signup Sucessfull";
                    int i = cmd.ExecuteNonQuery();
                        
                   
                }
                else
                {
                    Label5.Text = "Password mismatch with confirm password!Try Again";
                }
            }
        }
        }
    }
    
