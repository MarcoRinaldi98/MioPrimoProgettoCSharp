using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    public class Immobile
    {
        public string Codice { get; private set; }    
        public string Indirizzo { get; set; }
        public int Mq { get; set; }

        public Immobile(string indirizzo, int mq) 
        {
            this.Codice = "IMM" + Random.Shared.Next(0, 999);
            this.Indirizzo = indirizzo;
            this.Mq = mq;
        }

        public virtual void StampaInfo()
        {
            Console.WriteLine($@"
Immobile {this.Codice}:
- Indirizzo: {this.Indirizzo}
- Metri quadri: {this.Mq}");         
        }
    }
}
