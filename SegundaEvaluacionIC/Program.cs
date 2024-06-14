using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elige un tipo de nave para comandar:");
        Console.WriteLine("1. Caza (Vida: 120, Ataque: 15)");
        Console.WriteLine("2. Bombardero (Vida: 80, Ataque: 25)");
        Console.WriteLine("3. Consular (Vida: 100, Ataque: 20)");

        string shipSelection = Console.ReadLine();
        Player player = new Player("Jugador", 0, 'J');

        switch (shipSelection)
        {
            case "1":
                player.SwitchShip(new Fighter());
                break;
            case "2":
                player.SwitchShip(new Bomber());
                break;
            case "3":
                player.SwitchShip(new Consular());
                break;
            default:
                Console.WriteLine("Como no has elegido una nave, por defecto usaras al Caza");
                player.SwitchShip(new Fighter());
                break;
        }

        Enemy enemy = new Enemy("Enemigo", 100, 15);

        // Empezar el combate
        Combate combate = new Combate(player, enemy);
        combate.StartCombat();

        Console.WriteLine("Presiona cualquier tecla para salir");
        Console.ReadKey();
    }
}