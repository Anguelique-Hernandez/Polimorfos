using Demolterfaces;

Console.WriteLine("Demostración de  la implementación de interface");

List<Empleado> empleados = new List<Empleado>();

empleados.Add(new Empleado("Maria", "Moreno", "MOMA19570824ABC ", new DateTime(2016, 6,16), 350.0M));
empleados.Add(new Empleado("Aberto", "Arjona", "ARAL19970314DEF", new DateTime(2022, 1, 1), 300.0M));
empleados.Add(new Empleado("Raul", "Ramíerez", "RARA1985050801gh1", new DateTime(2020, 1, 1), 425.0M));
empleados.Add(new Empleado("Josefina", "Juárez", "JUJO19950915JKL", new DateTime(2021, 3, 16), 375.0M));

foreach (var empleado in empleados)
{
    ImprimirInfoDelEmpleado(empleado);
}

void ImprimirInfoDelEmpleado(Empleado empleado)
{
    {
        Console.WriteLine($"Nombre completo: {empleado.NombreCompeto}");
        Console.WriteLine($"Rfc: {empleado.Rfc}");
        Console.WriteLine($"Fecha de ingreso: {empleado.FechaDeIngreso}");
        Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
    }
}


