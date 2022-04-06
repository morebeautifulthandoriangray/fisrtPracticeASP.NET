using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            dictionary.Add("Name", "123");
            dictionary.Add("X", "Y");
            dictionary.ChangeKey("Name", "name");
            dictionary.ChangeKey("X", "x");

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            //dictionary.ChangeKey( TextBox1.Text, TextBox1.Text.ToLower());
            if (dictionary.ContainsKey(TextBox1.Text.ToLower()))
                if (dictionary[TextBox1.Text.ToLower()] == TextBox2.Text)
                    Response.Redirect("WebForm2.aspx");
                else
                    Label3.Text = "Wrong login or password";
            else
                Label3.Text = "Wrong login or password";
        }

        
    }

    public static class Extensions
    {
        public static bool ChangeKey<TKey, TValue>(this IDictionary<TKey, TValue> dict,
            TKey oldKey, TKey newKey)
        {
            TValue value;
            if (!dict.TryGetValue(oldKey, out value))
                return false;

            dict.Remove(oldKey);
            dict[newKey] = value;  // or dict.Add(newKey, value) depending on ur comfort
            return true;
        }
    }
}