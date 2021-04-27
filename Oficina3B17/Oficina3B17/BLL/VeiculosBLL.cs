using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using System.Data;
using DAL;

namespace BLL
{
    
    public class VeiculosBLL
    {
        DALProjeto dao;
        public VeiculosBLL()
        {
            dao = new DALProjeto("localhost", "oficina", "root", "");
        }
        public void InserirVeiculo(VeiculosDTO dto)
        {
            dao.Insert("tbl_veiculo", dto);
        }
        public void AlterarVeiculo(VeiculosDTO dto)
        {
            dao.Update("tbl_veiculo", dto, 0);
        }

        public void ExcluirVeiculo(VeiculosDTO dto)
        {
            dao.Delete("tbl_veiculo", dto, 0);
        }

        public DataTable ListarTodosVeiculos()
        {
            return dao.SelectAll("tbl_veiculo");
        }

        public DataTable ListarVeiculos(int id)
        {
            return dao.SelectWhere("tbl_veiculo", $"id = '{id}'");
        }
    }
}