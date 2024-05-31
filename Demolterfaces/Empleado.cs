namespace Demolterfaces
{
    public class Empleado : Persona, IAsalariable
    {
        public readonly decimal EstumuloPorAniosTrabajados = 50.0M;
        public readonly int MinimoDeAniosSinRecibirEstinulo = 5;
        public readonly int NumeroDeDiasDelPeriodo = 15;
        private decimal calcularAniosTrabajados;
        private decimal v;

        public string Rfc { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public int SalarioDiario { get; }
        public int salarioDiario { get; private set; }

        public Empleado(string nombre, string apellido, string rfc, DateTime fechaDeIngreso) : base(nombre, apellido)
        {
            Rfc = rfc;
            FechaDeIngreso = fechaDeIngreso;
            SalarioDiario = salarioDiario;
        }

        public Empleado(string nombre, string apellido, string rfc, DateTime fechaDeIngreso, decimal v) : this(nombre, apellido, rfc, fechaDeIngreso)
        {
            this.v = v;
        }

        public decimal CalcularSalarioFijoDelPeriodo(int numerosDeDiasTrabajados)
        {
            return salarioDiario * numerosDeDiasTrabajados;
        }
        public decimal CalcularEstimuladoPorAntiguedad()
        {
            int aniosLaborando = 0;
            decimal estimulo = 0.0M;

            if (FechaDeIngreso < DateTime.Now)
            {
                DateTime momentocero = new DateTime(1, 1, 1);
                TimeSpan lapso = DateTime.Now - FechaDeIngreso;
                aniosLaborando = (momentocero + lapso).Year;

            }
            if (aniosLaborando > MinimoDeAniosSinRecibirEstinulo)
            {
                estimulo = (aniosLaborando - MinimoDeAniosSinRecibirEstinulo) * EstumuloPorAniosTrabajados;
            }
            return estimulo;
        }
         public decimal CalcularSalio()
         {
            return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) * calcularAniosTrabajados;
         }

        public decimal CalcularSalario()
        {
            throw new NotImplementedException();
        }
    }
}
