namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        protected int Memoria { get; set; } //ao inves de privada, foi utilizada a visibilidade protegida para manipular a memória de acordo com a instalação de apps

        public void Ligar(string telefone)
        {
            Console.WriteLine($"Ligando para {telefone}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //adição de funcionalidade - calcular memória restante após instalação do app
        public abstract void InstalarAplicativo(string nomeApp, int memoriaApp);
    }
}