using System;
using System.Collections.Generic;
using EcosistemadeDispositivo.Models;

class Program
{
    static void Main(string[] args)
    {
        Dispositivo tv = new SmartTV("Samsung", "4K UHD");
        Dispositivo parlante = new ParlanteInteligente("Bose", 60);

        List<Dispositivo> listaDispositivos = new List<Dispositivo>();
        listaDispositivos.Add(tv);
        listaDispositivos.Add(parlante);

        Console.WriteLine("=== REPRODUCCIÓN MULTIMEDIA EN EL HOGAR ===");
        
        foreach (Dispositivo dispositivo in listaDispositivos)
        {
            dispositivo.ReproduceMedia();
        }
    }
}