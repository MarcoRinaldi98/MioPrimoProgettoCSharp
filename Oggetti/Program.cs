using Oggetti;

Auto miaAuto = new Auto(5, "blu", 60.0f);
Auto padreAuto = new Auto(3, "rossa", 35.0f);
Auto madreAuto = new Auto(5, "Pinco", 35.0f);

//Tento di accendere l'auto
miaAuto.PowerOn();

miaAuto.FillTank(10);

miaAuto.PowerOn();

miaAuto.PowerOff();

Console.WriteLine(miaAuto.Color);
miaAuto.Repaint("verde");
Console.WriteLine(miaAuto.Color);

Console.WriteLine($"Litri contenuti nel serbatoio: {miaAuto.GetCurrentTankLiters()}");