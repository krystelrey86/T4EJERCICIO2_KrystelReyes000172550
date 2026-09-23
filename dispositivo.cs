namespace EcosistemadeDispositivo.Models
{
    public class Dispositivo
    {
        public string Marca { get; set; }
        public Dispositivo(string marca)
        {
            Marca = marca;
        }

        public virtual void ReproduceMedia()
        {
            Console.WriteLine($"[Dispositivo {Marca}] Reproduciendo media en el dispositivo.");
        }
    }
}