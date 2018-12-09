using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public UserTipo TipoConta { get; set; }
    }

    public enum UserTipo
    {
        Admin = 1,
        Usuario = 2
    }


    public enum EAtivo
    {
        Ativo = 1,
        Inativo = 0
    }
}
