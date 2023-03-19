using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication40
{
    public partial class asdf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "KİLONUZ:";
            Label1.Font.Size = 15;
            Label2.Text = "BOYUNUZ(ör:1.60m):";
            Label2.Font.Size = 15;
            Button1.Text = "HESAPLA";
            Label3.Text = "VÜCUT KİTLE İNDEKSİ HESAPLAMA";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
             double  a = Convert.ToDouble(TextBox1.Text);
            double b = Convert.ToDouble(TextBox2.Text);
            double c =(a / (b * b))*10000;
            Label4.Text =Convert.ToString( c);
            }catch(Exception)
            {
                
            }
         
        }
    }
}