using System;

public class Combate
{
    private Player player;
    private Enemy enemy;

    public Combate(Player player, Enemy enemy)
    {
        this.player = player;
        this.enemy = enemy;
    }

    public void StartCombat()
    {
        Console.WriteLine("\nComienza el combate \n");

        while (player.IsAlive() && enemy.IsAlive())
        {
            // Turno del jugador
            player.Atacar(enemy);
            if (!enemy.IsAlive())
            {
                Console.WriteLine($"{enemy.Name} ha sido derrotado. {player.Name} gano!");
                break;
            }

            // Turno del enemigo
            enemy.Atacar(player);
            if (!player.IsAlive())
            {
                Console.WriteLine($"{player.Name} ha sido derrotado. {enemy.Name} gano!");
                break;
            }

            Console.WriteLine($"ahora te encuentras así: {player.Name} (Vida: {player.Health}), {enemy.Name} (Vida: {enemy.Health})");
        }
    }
}
