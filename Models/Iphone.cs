namespace SistemaCelular.Models;

public class Iphone(string numero, string modelo, string imei, int memoria) : Smatphone(numero, modelo, imei, memoria)
{
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando aplicativo {nomeApp}...");
    }
}