using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace billetSystemApi.Model
{
    public class KoretojDTO
    {
        public int pris { get; set;}
        public string type { get; set; }

        public KoretojDTO(int pris, string type)
        {
            this.pris = pris;
            this.type = type;
        }
        public KoretojDTO() { }
    }
}
