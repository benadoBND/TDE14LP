public class Carro : Veiculo, IFreavel, IAceleravel
{
    public string Marca {get; set;}
    public string Modelo {get; set;}

    public Carro (string marca, string modelo):base(marca, modelo)
    {
        
    }
    public override void Ligar()
    {
        Console.WriteLine("O carro está ligado!");
    }

    public void Acelerar()
    {
        Console.WriteLine($"O carro {Marca}, {Modelo} está acelerando");
    }

    public void Frear()
    {
        Console.WriteLine($"O carro {Marca}, {Modelo}, está freando");
    }
}