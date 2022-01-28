using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    internal class GameCharacter
    {
        public Random random = new();

        public string Player;
        public int Health;
        public int Strength;
        public int Stamina;
        public int Maxstamina;

        public GameCharacter(string player, int health, int str, int stam)
        {
            Player = player;
            Health = health;
            Strength = str;
            Stamina = stam;
            Maxstamina = stam;
        }

        public void Fight(GameCharacter Opponent)
        {
            if (Stamina <= 0)
            {
                Recharge();
            }
            else if (Opponent.Player == "Hero" && Stamina >= 10)
            {
                Strength = random.Next(0, 30);
                Opponent.Health -= Strength;
                Stamina -= 10;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Player} hit {Opponent.Player} for {Strength}! {Opponent.Player} has {Opponent.Health} health left ({Stamina}/{Maxstamina} Stamina)");
            }
            else if (Opponent.Player == "Boss" && Stamina >= 10)
            {
                Opponent.Health -= Strength;
                Stamina -= 10;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Player} hit {Opponent.Player} for {Strength}! {Opponent.Player} has {Opponent.Health} health left ({Stamina}/{Maxstamina} Stamina)");
            }
        }

        private void Recharge()
        {
            Stamina = Maxstamina;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{Player} had to restore Stamina!");
        }
    }
}
