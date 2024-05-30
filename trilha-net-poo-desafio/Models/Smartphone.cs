namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; }  // Propriedade apenas com getter, definida no construtor
        public string Marca { get; set; }  // Propriedade da marca do smartphone
        public string Modelo { get; set; }  // Propriedade do modelo do smartphone

        // Construtor para inicializar propriedades comuns
        public Smartphone(string numero, string marca, string modelo)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que cada modelo específico deverá implementar
        public abstract void InstalarAplicativo(string nomeApp);
    }
}