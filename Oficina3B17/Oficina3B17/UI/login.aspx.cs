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
    public partial class login : System.Web.UI.Page
    {
        string logins;
        string senha;

        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL usuariobll = new UsuarioBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
            }
            else
            {
                Response.Write("<script> alert('Você já está logado.');</script>");
                Response.Redirect("index.aspx", false);
            }
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt;
                logins = txtLogin.Text;
                senha = txtSenha.Text;

                dt = usuariobll.carregarUsuario(logins, senha);

                if (dt.Rows.Count == 1)
                {
                    usuario.Id = int.Parse(dt.Rows[0][0].ToString());
                    usuario.Login = dt.Rows[0][1].ToString();
                    usuario.Senha = dt.Rows[0][2].ToString();
                }
                else
                {
                    dt = null;
                }

                if (dt != null)
                {
                    Session["usuario"] = usuario;
                    Response.Redirect("index.aspx", false);
                }
                else
                {
                    Response.Write("<script> alert('usuario ou senha incorretos');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}