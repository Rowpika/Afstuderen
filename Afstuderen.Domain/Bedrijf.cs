using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afstuderen.Domain
{
    public class Bedrijf
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adress { get; set; }
        [DisplayName("Vestigings plaats")]
        public string Vestigingsplaats { get; set; }
        [RegularExpression(@"(^[0-9]{10})$", ErrorMessage = "Omjuist")]
        public string Telefoon { get; set; }
    }
}
