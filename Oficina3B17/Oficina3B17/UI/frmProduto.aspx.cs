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
    public partial class frmProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ExibirDados();
            }

        }
        private void ExibirDados()
        {
            GridView1.DataSource = new ProdutoBLL().ListarTodosProdutos();
            DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ExibirDados();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Nome = e.NewValues[1].ToString();
            dto.Preco = Convert.ToInt32(e.NewValues[2]);
            dto.Qtde_estoque = Convert.ToInt32(e.NewValues[3]);
           

            new ProdutoBLL().AlterarProduto(dto);
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ProdutoDTO dto = new ProdutoDTO();
            dto.Id = Convert.ToInt32(e.Values[0]);
            new ProdutoBLL().ExcluirProduto(dto);
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDTO dto = new ProdutoDTO();
                dto.Nome = txtNome.Text;
                dto.Preco = double.Parse(txtPreco.Text);
                dto.Qtde_estoque= int.Parse(txtQtdEstoque.Text);
             

                
                    new ProdutoBLL().InserirProduto(dto);
                    new LimpaForm(this.Form.Controls);
                    ExibirDados();

               
                }

           
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}