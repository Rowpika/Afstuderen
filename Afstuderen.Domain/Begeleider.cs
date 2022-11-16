using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afstuderen.Domain
{
    public class Begeleider
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public BegeleiderRol Rol { get; set; }

        public enum BegeleiderRol
        {
            DocentBegeleider,
            TweedeLezer,
            TechnischBegeleider,
            ProcesBegeleider,
            ExternGecommiteerde
        }
    }
}
    
    

