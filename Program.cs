using System;

namespace DesafioPOO.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de instância da classe Nokia
            Nokia nokia = new Nokia("123456789", "Nokia Model X", "IMEI123", 64);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Exemplo de instância da classe Iphone
            Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine(); // Para manter a janela do console aberta
        }
    }
}
