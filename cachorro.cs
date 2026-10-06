using System;

namespace ZoologicoConsole;

public class Cachorro : Animal
{
    public Cachorro() : base("Cachorro", "Canis lupus", "30", "4", "Carnívoro")
    {
    }
public override void exibircaracteristicas()
    {
        base.exibircaracteristicas();
        Console.WriteLine("O cachorro é um animal doméstico muito popular, conhecido por sua lealdade e amizade com os humanos.");
    }

    public override void emitirSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}