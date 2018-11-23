using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MyFactory.SITInfo.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o Nome do usuário", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o Email do usuário", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage ="Informe um email válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }

        public bool Ativo   { get; set; }
        //public bool? Ativo { get; set; } = null;

        public UserTipo TipoConta { get; set; }


    }
}