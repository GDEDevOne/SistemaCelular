
namespace SistemaCelular.Models;

public abstract class Smatphone(string numero, string modelo, string imei, int memoria)
{
    public string Numero { get; set; } = numero;
    public string Modelo { get; set; } = modelo;
    public string Imei { get; set; } = imei;
    public int Memoria { get; set; } = memoria;

    public void Ligar()
    {
        Console.WriteLine("Ligando...");
    }

    public void ReceberLigação()
    {
        Console.WriteLine("Recebendo ligação...");
    }

    public abstract void InstalarAplicativo(string nomeApp);
}