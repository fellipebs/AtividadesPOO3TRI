using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;
using System.Data;

namespace Oficina3B17.UI
{
    public partial class VisualizarVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaDono();
                CarregaModelo();
                if(Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    DataTable dt = new VeiculosBLL().ListarVeiculos(id);
                    if (dt.Rows.Count > 0)
                    {
                        txtPlaca.Text = dt.Rows[0][1].ToString();
                        txtAno.Text = Convert.ToInt32(dt.Rows[0][2]).ToString();
                        txtCor.Text = dt.Rows[0][3].ToString();
                        dplDono.SelectedValue = Convert.ToInt32(dt.Rows[0][4]).ToString();
                        dplModelo.SelectedValue = Convert.ToInt32(dt.Rows[0][5]).ToString();
                    }
                    else
                    {
                        Response.Redirect("FrmVeiculo.aspx");
                    }
                }
                else
                {
                    Response.Redirect("FrmVeiculo.aspx");
                }
            }
        }

        public void CarregaDono()
        {
            dplDono.DataSource = new ClienteBLL().ListarTodosClientes();
            dplDono.DataTextField = "nome";
            dplDono.DataValueField = "id";
            DataBind();
        }

        public void CarregaModelo()
        {
            dplModelo.DataSource = new ModeloBLL().ListarTodosModelos();
            dplModelo.DataTextField = "nome";
            dplModelo.DataValueField = "id";
            DataBind();
        }
    }
}