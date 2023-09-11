using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    public class Abitazione : Immobile
    {
        public int Vani {  get; set; }
        public int Bagni { get; set; }

        public Abitazione(string indirizzo, int mq, int vani, int bagni) : base(indirizzo, mq)
        {
            this.Vani = vani;
            this.Bagni = bagni;
        }

        public override void StampaInfo()
        {
            base.StampaInfo();
            Console.WriteLine($@"- Numero vani: {this.Vani}
- Numero bagni: {this.Bagni}");
        }
    }
}
