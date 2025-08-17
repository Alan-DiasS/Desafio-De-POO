namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria)
            : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            // TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}