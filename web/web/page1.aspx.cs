using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace web
{
    class cal
    {
        public int sum(int x ,int y)
        {
            return x + y;

        }
        public int sub(int x, int y)
        {
            return x - y;

        } 
        public int mul(int x, int y)
        {
            return x * y;

        }
        public int div(int x, int y)
        {
            return x / y;

        }


    }
    public partial class page1 : System.Web.UI.Page
    {
        cal c = new cal();
        protected void Page_Load(object sender, EventArgs e)
        {
           
          
            
            //int x=Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HtmlInputText input=new HtmlInputText();
           // Label3 l = new Label3();
            
            //Label1.Text = "rahma";
         // Image1.Attributes.Add
        


        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = c.sum(x, y);
            Label3.Text = z.ToString();

            //cal c = new cal();
            //int add = c.sum(Convert.ToInt32(Label3.Text), Convert.ToInt32(Label3.Text));
            //Console.WriteLine(add);
            //Label3.Text = Convert.ToString(add);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = c.sub(x, y);
            Label4.Text = z.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = c.mul(x, y);
            Label5.Text = z.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TextBox1.Text);
            int y = Convert.ToInt32(TextBox2.Text);
            int z = c.div(x, y);
            Label6.Text = z.ToString();
        }
    }
}