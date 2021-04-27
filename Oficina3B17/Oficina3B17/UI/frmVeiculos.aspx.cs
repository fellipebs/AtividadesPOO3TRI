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
    public partial class frmVeiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaDono();
                CarregaModelo();
                ExibirDados();
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

        public void ExibirDados()
        {
            GridView1.DataSource = new VeiculosBLL().ListarTodosVeiculos();
            DataBind();
        }
        protected void btnGrava_Click(object sender, EventArgs e)
        {
            try
            {
            VeiculosDTO dto = new VeiculosDTO();
            dto.Placa = txtPlaca.Text;
            dto.Ano = int.Parse(txtAno.Text);
            dto.Cor = txtCor.Text.ToString();
            dto.Id_dono = Convert.ToInt32(dplDono.SelectedValue);
            dto.Id_modelo = Convert.ToInt32(dplModelo.SelectedValue);

            new VeiculosBLL().InserirVeiculo(dto);
            new LimpaForm(this.Form.Controls);
            ExibirDados();
            }


            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ExibirDados();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            VeiculosDTO dto = new VeiculosDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Placa = e.NewValues[1].ToString();
            dto.Ano = Convert.ToInt32(e.NewValues[2]);
            dto.Cor = e.NewValues[3].ToString();
            dto.Id_dono = Convert.ToInt32(e.NewValues[4]);
            dto.Id_modelo = Convert.ToInt32(e.NewValues[5]);

            new VeiculosBLL().AlterarVeiculo(dto);
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            VeiculosDTO dto = new VeiculosDTO();
            dto.Id = Convert.ToInt32(e.Values[0]);
            new VeiculosBLL().ExcluirVeiculo(dto);
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            ExibirDados();
        }
    }
}