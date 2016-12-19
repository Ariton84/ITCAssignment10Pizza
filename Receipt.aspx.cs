using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class Receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Meal"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        DisplayReceipt();
    }

    protected void DisplayReceipt()
    {
        StringBuilder sb = new StringBuilder();
        MealOrder meal = (MealOrder)Session["Meal"];
        List<string> sizes = meal.Sizes;
        List<string> toppings = meal.Toppings;

        sb.Append("<br/>Pies<br/>");
        foreach (string size in sizes)
        {
            sb.Append(size);
            sb.Append("<br/>");
        }
        sb.Append("<br/>Toppings<br/>");
        foreach (string topping in toppings)
        {
            sb.Append(topping);
            sb.Append("<br/>");
        }
        sb.Append("<br/>Total");
        sb.Append("<br/>");
        sb.Append(meal.Calculatetotal().ToString());
        Label1.Text = sb.ToString();
    }
} 