namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor que repassa os parâmetros para a classe base
        public Iphone(string numero, string modelo) : base(numero, "Apple", modelo)
        {
            // Configurações específicas do iPhone, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Apple.");
        }
    }
}
