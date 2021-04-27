﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class ClienteDTO
    {
        private int id;
        private string nome;
        private DateTime data_nascimento;
        private int telefone;
        private int cpf;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Cpf { get => cpf; set => cpf = value; }
    }
}