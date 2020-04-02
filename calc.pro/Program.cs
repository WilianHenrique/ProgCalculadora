using System;

namespace calc.pro
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            c.addNumero(10.1);
            c.addNumero(2.9);

            System.Console.WriteLine(c.somar());

            c.addNumero(10.1);
            c.addNumero(4.9);

            System.Console.WriteLine(c.somar());

            c.addNumero(10);
            c.addNumero(5);
            c.addNumero(2);
            System.Console.WriteLine(c.subtrair());

            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.multiplicar());

            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.dividir());

            System.Console.ReadKey();
        }
    }
}
