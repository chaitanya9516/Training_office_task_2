using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emploee
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void ddlCompany_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string selectedDdl = ddlCompany.Text;

            if (selectedDdl.Contains("suja"))
            {

                List<string> desigination = new List<string>();
                desigination.Add("Select");
                desigination.Add("developer");
                desigination.Add("designer");
                desigination.Add("tester");
                ddlDesignation.DataSource = desigination;
                ddlDesignation.DataBind();

            }
            
            else if (selectedDdl.Contains("google"))
            {

                List<string> desigination = new List<string>();
                desigination.Add("Select");
                desigination.Add("a");
                desigination.Add("b");
                desigination.Add("c");
                ddlDesignation.DataSource = desigination;
                ddlDesignation.DataBind();

            }
            else if (selectedDdl.Contains("microsoft"))
            {

                List<string> desigination = new List<string>();
                //desigination.Insert(0, "Select");
                desigination.Add("Select");
                desigination.Add("e");
                desigination.Add("f");
                desigination.Add("g");
                ddlDesignation.DataSource = desigination;
                ddlDesignation.DataBind();

            }
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var name = txtBoxFn.Text;
            
            string checkedval = "";

            
            if (rbtnMale.Checked ) checkedval = rbtnMale.Text; 

            else if (rtbnFemale.Checked) checkedval = rtbnFemale.Text;
       
            var companyName = ddlCompany.SelectedValue;
            
            var ddl_Designation = ddlDesignation.SelectedValue;

            var isVaild = name == "" || name == " " || checkedval == "" || ddlCompany.SelectedIndex == 0 || ddlDesignation.SelectedIndex == 0;

          
            if (isVaild)  lblDisplayError.Text = "Please Enter Your Details";
            
            else 
                
               Response.Redirect("/result.aspx?Name=" + txtBoxFn.Text + "&gender=" + checkedval + "&company=" + companyName + "&designation=" + ddl_Designation);
            
        }
    }
}