namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia  : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            public override void InstalarAplicativo(string nomeApp)
            {
            // instalação de aplicativo em um Nokia
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
            }
        }
    }
}