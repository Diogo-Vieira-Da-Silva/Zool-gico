using System;

namespace ZoologicoConsole;

public class Gato : Animal
{
    public Gato() : base("Gato", "Felis catus", "5", "4", "Carnívoro")
    {
    }
public override void exibircaracteristicas()
    {
        base.exibircaracteristicas();
        Console.WriteLine("O gato é um animal doméstico muito popular, conhecido por sua independência e graça.");
    }

    public override void emitirSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}