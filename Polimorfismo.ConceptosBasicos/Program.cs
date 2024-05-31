using Polimorfismo.ConceptosBasicos;

Console.WriteLine("Demostración de conceptos básicos del polimorfismo.\n");

ClaseBase claseBase = new ClaseBase ();
ClaseDerivada claseDerivada = new ClaseDerivada();
ClaseDerivada cbcd = new ClaseDerivada();

claseBase.Metodo1();
claseDerivada.Metodo2();
claseDerivada.Metodo1();
claseDerivada.Metodo2();
cbcd.Metodo1();
cbcd.Metodo2();