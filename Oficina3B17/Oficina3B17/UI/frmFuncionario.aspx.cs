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
    public partial class frmFormulario : System.Web.UI.Page
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
            GridView1.DataSource = new FuncionarioBLL().ListarTodosFuncionarios();
            DataBind();
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDTO funcionarioDTO = new FuncionarioDTO();
                funcionarioDTO.Nome = txtNome.Text;
                funcionarioDTO.Data_nascimento = Calendar1.SelectedDate;
                funcionarioDTO.Telefone =  txtTelefone.Text;
                funcionarioDTO.Cpf = txtCpf.Text;

                if (txtID.Text == string.Empty)
                {
                    new FuncionarioBLL().InserirFuncionario(funcionarioDTO);
                    new LimpaForm(this.Form.Controls);
                    ExibirDados();

                }
                else
                {
                   
                }
                
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
            FuncionarioDTO dto = new FuncionarioDTO();

            dto.Id = Convert.ToInt32(e.NewValues[0]);
            dto.Nome = e.NewValues[1].ToString();
            dto.Data_nascimento = Convert.ToDateTime(e.NewValues[2]);
            dto.Telefone = e.NewValues[3].ToString();
            dto.Cpf = e.NewValues[4].ToString();

            new FuncionarioBLL().AlterarFuncionario(dto);
            GridView1.EditIndex = -1;
            ExibirDados();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            FuncionarioDTO dto = new FuncionarioDTO();
            dto.Id = Convert.ToInt32(e.Values[0]);
            new FuncionarioBLL().ExcluirFuncionario(dto);
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