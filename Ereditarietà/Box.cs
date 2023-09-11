using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    public class Box : Immobile
    {
        public int PostiAuto {  get; private set; }

        public Box(string indirizzo, int mq, int postiAuto) : base(indirizzo, mq)
        {
            this.PostiAuto = postiAuto;
        }

        public override void StampaInfo()
        {
            base.StampaInfo();
            Console.WriteLine($"- Posti auto: {this.PostiAuto}");   
        }
    }
}
