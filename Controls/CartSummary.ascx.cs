﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportsStore.Models;
using SportsStore.Pages.Helpers;
using System.Web.Routing;

namespace SportsStore.Controls
{
    public partial class CartSummary : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart myCart = SessionHelper.GetCart(Session);
            csQuantity.InnerText = myCart.Lines.Sum(x => x.Quantity).ToString();
            csTotal.InnerText = myCart.ComputeTotalValue().ToString("c");
            csLink.HRef = RouteTable.Routes.GetVirtualPath(null, "cart", null).VirtualPath;
        }
    }
}