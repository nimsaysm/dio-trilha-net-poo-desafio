namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        //usando o construtor
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp, int memoriaApp)
        {
            Memoria = Memoria - memoriaApp;
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso. Restam {Memoria} GB.");
        }
    }
}