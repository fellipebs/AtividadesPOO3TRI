using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    public class ProdutoBLL
    {
        DALProjeto dao;
        public ProdutoBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public void InserirProduto(ProdutoDTO dto)
        {
            dao.Insert("tbl_produto", dto);
        }
        public void AlterarProduto(ProdutoDTO dto)
        {
            dao.Update("tbl_produto", dto, 0);
        }

        public void ExcluirProduto(ProdutoDTO dto)
        {
            dao.Delete("tbl_produto", dto, 0);
        }

        public DataTable ListarTodosProdutos()
        {
            return dao.SelectAll("tbl_produto");
        }
    }
}