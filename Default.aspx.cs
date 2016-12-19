using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateSizes();
            PopulateToppings();
        }
    }

    protected void PopulateSizes()
    {
        string[] size = {"Small  12in.", "Medium  14in.", "Large  18in."};
        CBLSizes.DataSource = size;
        CBLSizes.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MealOrder meal = new MealOrder();
        foreach (ListItem item in CBLSizes.Items)
        {
            if (item.Selected)
            {
                meal.AddSizes(item.Text);
            }
        }
        foreach (ListItem item in CBLToppings.Items)
        {
            if (item.Selected)
            {
                meal.AddToppings(item.Text);
            }
        }
        Session["Meal"] = meal;
        Response.Redirect("Receipt.aspx");
    }

    protected void PopulateToppings()
    {
        string[] topping = {"Pepperoni", "Sausage", "Pinapple", "Canadian Bacon", "Extra Cheese"};
        CBLToppings.DataSource = topping;
        CBLToppings.DataBind();
    }
}