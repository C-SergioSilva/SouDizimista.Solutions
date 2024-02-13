using SouDizimista.Domain.Guids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouDizimista.Domain.Entities
{
    public class MenuItemLateral : EntityGuid
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string UrlModulo { get; set; }   
    }
}
