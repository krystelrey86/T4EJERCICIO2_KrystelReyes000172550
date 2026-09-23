namespace EcosistemadeDispositivo.Models
{
    public class ParlanteInteligente : Dispositivo
    {
        public int PotenciaWatts{ get; set; }
        public ParlanteInteligente(string marca, int potenciaWatts) : base(marca)
        {
            PotenciaWatts = potenciaWatts;
        }

        public override void ReproduceMedia()
        {
            Console.WriteLine($"[Parlante Inteligente {Marca}]: Reproduciendo audio con potencia de {PotenciaWatts} watts.");
        }
    }

}