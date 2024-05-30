using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto Nokia
            Smartphone nokia = new Nokia("987654321", "Nokia 8");

            // Criando um objeto iPhone
            Smartphone iphone = new Iphone("123456789", "iPhone 12");

            // Testando funcionalidades do Nokia
            Console.WriteLine($"Número do Nokia: {nokia.Numero}");
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Facebook");

            Console.WriteLine();

            // Testando funcionalidades do iPhone
            Console.WriteLine($"Número do iPhone: {iphone.Numero}");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");

            Console.ReadLine();
        }
    }
}
