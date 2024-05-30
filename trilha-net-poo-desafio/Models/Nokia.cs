namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor que repassa os parâmetros para a classe base
        public Nokia(string numero, string modelo) : base(numero, "Nokia", modelo)
        {
            // Configurações específicas de celulares Nokia, se necessário
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia.");
        }
    }
}
