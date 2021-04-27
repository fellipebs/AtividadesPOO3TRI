using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oficina3B17.UI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmFuncionario.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmProduto.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmVeiculos.aspx");
        }
    }
}