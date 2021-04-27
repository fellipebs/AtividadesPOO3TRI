using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTO
{
    public class UsuarioDTO
    {
        private int id;
        private string login;
        private string senha;

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}