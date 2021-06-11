using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emploee
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Convert.ToString(Request.QueryString["Name"]);
            string gender = Convert.ToString(Request.QueryString["gender"]);
            string company = Convert.ToString(Request.QueryString["company"]);
            string designation = Convert.ToString(Request.QueryString["designation"]);
           
           //Response.Output.Write("Name = {0} <br/> gender = {1} <br/> company = {2} <br/> designation = {3}", name, gender, company, designation);

            Response.Output.Write("Name = {0} <br/> gender = {1} <br/> company = {2} <br/> designation = {3}", name, gender, company, designation);

        }
    }
}