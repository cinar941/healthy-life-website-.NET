using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication40
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Label1.Text = "SPOR İLE HAYAT DEĞİŞİR";
            Label1.Font.Size = 25;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
       
            Response.Redirect("https://www.kisa.link/O71d ");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.kisa.link/O71k ");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
           
        }
    }
}