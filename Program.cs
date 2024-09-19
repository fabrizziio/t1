using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese su salario bruto del mes: ");
        double SB = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese las ventas realizadas: ");
        double ventas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad de años en la empresa: ");
        int añosEnEmpresa = Convert.ToInt32(Console.ReadLine());
        double CO;
        if (ventas <= 600)
        {
            CO = ventas * 0.05;
        }
        else if (ventas <= 3000)
        {
            CO = ventas * 0.07;
        }
        else
        {
            CO = 300 + (ventas * 0.06);
        }

        double TG = SB + CO;
        double DSCTOP = (añosEnEmpresa <= 3) ? 0.065 : 0.045;
        double DSCTO = TG * DSCTOP;
        double SNTO = TG - DSCTO;

       
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Total ganado: {TG:C}");
        Console.WriteLine($"Descuento en dinero: {DSCTO:C}");
        Console.WriteLine($"Salario neto: {SNTO:C}");
    }
}