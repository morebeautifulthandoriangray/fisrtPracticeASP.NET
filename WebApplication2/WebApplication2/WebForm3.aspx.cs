using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "TextBox: " + TextBox1.Text;
            str += "<br/>ListBox: " + ListBox1.Text;
            str += "<br/>DropDownList: " + DropDownList1.Text;

            if(RadioButton1.Checked) str += "<br/>RadioButton: " + RadioButton1.Text;
            if (RadioButton2.Checked) str += "<br/>RadioButton: " + RadioButton2.Text;
            if (RadioButton3.Checked) str += "<br/>RadioButton: " + RadioButton3.Text;

            Label1.Text = str;
        }
    }
}