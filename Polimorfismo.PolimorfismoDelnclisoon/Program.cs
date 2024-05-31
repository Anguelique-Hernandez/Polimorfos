using Polimorfismo.PolimorfismoDelnclison;
using Polimorfismo.PolimorfismoDelnclisoon;

Console.WriteLine("Demostraciónd del polimorfismo de inclusion(subtipificación)\n");

ClaseBase ClaseBase = new ClaseBase();
ClaseDerivada claseDerivada = new ClaseDerivada();
ClaseDerivada cbcd = new ClaseDerivada();

ClaseBase.Metodo1();
claseDerivada.Metodo2();
claseDerivada.Metodo1();
claseDerivada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo2();
