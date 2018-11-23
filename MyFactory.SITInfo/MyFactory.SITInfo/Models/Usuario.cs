﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFactory.SITInfo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public UserTipo TipoConta { get; set; }
    }

    public enum UserTipo
    {
        Admin = 1,
        Usuario = 2

    }
}
