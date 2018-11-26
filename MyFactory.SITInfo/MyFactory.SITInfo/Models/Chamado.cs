using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFactory.SITInfo.Models
{
    public class Chamado
    {
        public int  id { get; set; }
        public string EmailUsuario { get; set; }
        public DateTime DataAbertura { get; set; }
        public EPrioridade Prioridade { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFechamento { get; set; }

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