using System;
namespace ZoologicoConsole;

public abstract class Animal
{
    public string nome {get;}
    public string especie {get;}
    public string pesoemKg {get;}
    public string quantidadedepatas {get;}

    public string alimentacao {get;}



    protected Animal(string nome, string especie, string pesoemKg, string quantidadedepatas, string alimentacao)
    {
        this.nome = nome;
        this.especie = especie;
        this.pesoemKg = pesoemKg;
        this.quantidadedepatas = quantidadedepatas;
        this.alimentacao = alimentacao;
    }

    public virtual void exibircaracteristicas()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Espécie: {especie}");
        Console.WriteLine($"Peso em Kg: {pesoemKg}");
        Console.WriteLine($"Quantidade de Patas: {quantidadedepatas}");
        Console.WriteLine($"Alimentação: {alimentacao}");
    }

    public virtual void emitirSom()
    {
        Console.WriteLine($"O {nome} emite um som.");
    }
}
