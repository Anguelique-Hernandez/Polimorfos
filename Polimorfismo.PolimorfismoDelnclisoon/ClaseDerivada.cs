using Polimorfismo.PolimorfismoDelnclisoon;

namespace Polimorfismo.PolimorfismoDelnclison
{
    public class ClaseDerivada : ClaseBase
    {
        
         public override void Metodo1()
         {
            Console.WriteLine("Metodo1() en claseDerivada");

         }

        public new void Metodo2()
        {
            Console.WriteLine("Metodo2() en ClaseDerivada");
        }
    }
}
 