using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    public class Villa : Immobile
    {
        public int MqGiardino { get; private set; }

        public Villa(string indirizzo, int mq, int mqGiardino) : base(indirizzo, mq)
        {
            this.MqGiardino = mqGiardino;
        }

        public override void StampaInfo()
        {
            base.StampaInfo();
            Console.WriteLine($"- Mq Giardino: {this.MqGiardino}");
        }

        public void StampaInfoGiardino()
        {
            Console.WriteLine($"Il giardino della villa è di {this.MqGiardino}mq");
        }
    }
}
