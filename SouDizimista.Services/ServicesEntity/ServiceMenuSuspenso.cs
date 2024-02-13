using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServiceMenuSuspenso
    {
        public Guid IDFuncionalidade { get; set; }
        public int NumeroFuncionalidade { get; set; }
        public string NomeFuncionalidade { get; set; }
        public int? IDFuncionalidadePai { get; set; }
        public int? NumeroOrdenacaoFuncionalidade { get; set; }
        public string URLFuncionalidade { get; set; }
        public bool IndicadorAtivo { get; set; }

    }
}
