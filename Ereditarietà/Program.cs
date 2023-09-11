using Ereditarietà;

Immobile CondominioAbaco = new Immobile("Via Roma 106, Milano, MI", 15000);
Villa villaFoscolo = new Villa("Via Galileo, 105, Roma, RM", 1000, 300);
Abitazione abitazioneBryan = new Abitazione("Via Pinco, 14, Conegliano, TV", 100, 8, 2);
Box boxAuto = new Box("Viale angelico, 35, Roma, RM", 1000, 4);

CondominioAbaco.StampaInfo();
villaFoscolo.StampaInfo();
abitazioneBryan.StampaInfo();
boxAuto.StampaInfo();

List<Immobile> laMiaListaDiimmobile  = new List<Immobile>();
laMiaListaDiimmobile.Add(CondominioAbaco);
laMiaListaDiimmobile.Add(villaFoscolo);
laMiaListaDiimmobile.Add(abitazioneBryan);
laMiaListaDiimmobile.Add(boxAuto);

foreach(Immobile immobile in laMiaListaDiimmobile)
{
    immobile.StampaInfo();

    if(immobile is Villa)
    {
        Villa villa = (Villa)immobile;
        villa.StampaInfoGiardino();
    }
}