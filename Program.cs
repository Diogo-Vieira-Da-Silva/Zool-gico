using System;

namespace ZoologicoConsole;

public class Program
{
    public static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            ExibirMenu();
            string? opcao = Console.ReadLine();

            if (opcao == "0")
            {
                continuar = false;
                Console.WriteLine("\nEncerrando o Programa");
                continue;
            }

            Animal? animal = CriarAnimal(opcao);
            if (animal == null)
            {
                Console.WriteLine("\nOpção inválida. Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("\nCaracterísticas do Animal:");
        

            animal.exibircaracteristicas();
            Console.WriteLine("\nSom emitido pelo animal:");
            animal.emitirSom();
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
          
        }
    }

    private static void ExibirMenu()
    {
        Console.Clear();
        Console.WriteLine("===================");
        Console.WriteLine("Fazenda dos Animais");
        Console.WriteLine("===================");
        Console.WriteLine("1 - Cachorro");
        Console.WriteLine("2 - Gato");
        Console.WriteLine("0 - Sair");
        Console.Write("\nEscolha uma opção: ");
    }

    private static Animal? CriarAnimal(string? opcao)
    {
        switch (opcao)
        {
            case "1":
                return new Cachorro();
            case "2":
                return new Gato();
            default:
                return null;
        }
    }
}
