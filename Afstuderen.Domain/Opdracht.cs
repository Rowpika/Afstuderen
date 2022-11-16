using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afstuderen.Domain
{
    public class Opdracht
    {
        public int Id { get; set; }
        public string Naam { get; set; }

        public string Omschrijving { get; set; }

        public Student Afstudeerder1 { get; set; }
        public Student Afstudeerder2 { get; set; }
        public Bedrijf Opdrachtgever { get; set; }
        public List<Begeleider> Begeleiders { get; set; }
    }
}
