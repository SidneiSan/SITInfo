using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFactory.SITInfo.Models
{
    public class Chamado
    {
        [Display(Name = "Id Chamado")]
        public int  id { get; set; }
        [Display(Name = "Email do Usuário")]
        [Required(ErrorMessage = "Informe o Email do usuário", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Informe um email válido!")]
        public string EmailUsuario { get; set; }

        [Display(Name = "Data da Abertura")]
        [Required(ErrorMessage = "Informe a Data de Abertura", AllowEmptyStrings = false)]
        public DateTime DataAbertura { get; set; }

        
        public EPrioridade Prioridade { get; set; }

        [Required(ErrorMessage = "Informe o Titulo do Chamado", AllowEmptyStrings = false)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Informe a Descrição do Chamado", AllowEmptyStrings = false)]
        [MaxLength(5000,ErrorMessage ="Tamanho ultrapassa o limite permitido 100 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data Fechamento")]

        public DateTime? DataFechamento { get; set; }

    }


    public enum EPrioridade
    {
        MuitoAlta = 0,
        Alta = 1,
        Normal = 2,
        Baixa = 3,
        MuitoBaixa = 5
    }
}