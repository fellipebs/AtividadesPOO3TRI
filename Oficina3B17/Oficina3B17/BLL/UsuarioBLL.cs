using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        DALProjeto dao;
        public UsuarioBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public DataTable carregarUsuario(string login, string senha)
        { 
           return dao.SelectWhere("tbl_usu", $@" login = '{login}' AND senha = '{senha}'");   
        }
    }
}