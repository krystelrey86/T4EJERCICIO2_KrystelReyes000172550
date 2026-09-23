namespace EcosistemadeDispositivo.Models
{
    public class SmartTV : Dispositivo
    {
        public string Resolucion { get; set; }
        public SmartTV(string marca, string resolucion) : base(marca)
        {
            Resolucion = resolucion;
        }

        public override void ReproduceMedia()
        {
            Console.WriteLine($"[Smart TV {Marca}]: Procesando y reproduciendo video en resolución {Resolucion}.");
        }
    }
}