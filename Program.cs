using System;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liberte a princesa");
            Local currentPlace = Prepare.Map();
            while (true)
            {
                print(currentPlace);
                string key = Console.ReadKey().KeyChar.ToString();
                switch (key)
                {
                    case "q":
                        return;

                    case "n":
                        if (currentPlace.North == null)
                            Console.WriteLine("Você não pode ir para o norte");
                        else
                            currentPlace = currentPlace.North;
                        break;

                    case "l":
                        if (currentPlace.East == null)
                            Console.WriteLine("Você não pode ir para o leste");
                        else
                            currentPlace = currentPlace.East;
                        break;

                    case "s":
                        if (currentPlace.South == null)
                            Console.WriteLine("Você não pode ir para o sul");
                        else
                            currentPlace = currentPlace.South;
                        break;

                    case "o":
                        if (currentPlace.West == null)
                            Console.WriteLine("Você não pode ir para o oeste");
                        else
                            currentPlace = currentPlace.West;
                        break;

                    case "d":
                        Console.WriteLine(currentPlace.Description);
                        break;

                    default:
                        Console.WriteLine("Não entendi");
                        break;
                }
            }
        }

        static void print(Local currentPlace)
        {
            if (!currentPlace.Visited)
            {
                currentPlace.Visited = true;
                Console.WriteLine(currentPlace.Description);
            }

            Console.WriteLine("Você está aqui: " + currentPlace.Title);
            Console.WriteLine("Ir para:");

            if (currentPlace.North != null)
                Console.WriteLine("n = " + currentPlace.North.Title);
            if (currentPlace.East != null)
                Console.WriteLine("l = " + currentPlace.East.Title);
            if (currentPlace.South != null)
                Console.WriteLine("s = " + currentPlace.South.Title);
            if (currentPlace.West != null)
                Console.WriteLine("o = " + currentPlace.West.Title);

            Console.WriteLine("q = sair, d = descrever");
        }
    }
}
