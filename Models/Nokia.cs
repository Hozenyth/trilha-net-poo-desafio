namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"

        public override void InstalarAplicativo(global::System.String nomeApp)
        {
            Console.WriteLine($"Instalando...{nomeApp}");
        }
    }
}