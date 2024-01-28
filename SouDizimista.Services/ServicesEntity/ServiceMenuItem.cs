using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Services.ServicesEntity
{
    public class ServiceMenuItem
    {
        public Guid? Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string UrlModulo { get; set; }

    }
}
