public class Bicicleta: Veiculo, IAceleravel
{
    public Bicicleta(string marca, string modelo)
    :base(marca, modelo)
    {

    }
    public void Acelerar()
    {
        Console.WriteLine($"A {Marca} e {Modelo} está pedalando!");
    }
    public override void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} está pronta para o uso!");
    }
}