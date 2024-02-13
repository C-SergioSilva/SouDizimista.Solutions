using SouDizimista.Domain.Guids;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Entities
{
    public class MenuSuspenso : EntityGuid
    {
        public int NumeroFuncionalidade { get; set; }   
        public string NomeFuncionalidade { get; set; }
        public int? IDFuncionalidadePai { get; set; }
        public int? NumeroOrdenacaoFuncionalidade { get; set; }
        public string URLFuncionalidade { get; set; }
        public bool IndicadorAtivo { get; set; }
     }
}
