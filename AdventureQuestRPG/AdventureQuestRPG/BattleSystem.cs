using System;

namespace AdventureQuestRPG
{
    public class BattleSystem
    {
        public static int Attack(dynamic attacker, dynamic target)
        {

            int damage = 0;
            if (target.Health < 0)
            {

                Console.WriteLine($"{target.Name} is already defeated.");
                damage = 0;
                
            }
            else {

                 damage = attacker.AttackPower - target.Defense;
                    target.Health -= damage;
                if (target.Health < 0)
                {
                    target.Health = 0;
                }

            }
            Console.WriteLine($"{attacker.Name} hits {target.Name} with damage dealt: {damage}. Updated health of {target.Name} is: {target.Health}");
            return target.Health;
        }

        public static int StartBattle(Player attacker, Monster target)
        {
            Random rand = new Random();

            while (attacker.Health > 0 && target.Health > 0)
            {
                int turn = rand.Next(2);
                if (turn == 0)
                {
                    Console.WriteLine($"{attacker.Name}'s turn.");
                    Attack(attacker, target);
                }
                else
                {
                    Console.WriteLine($"{target.Name}'s turn.");
                    Attack(target, attacker);
                }
            }

            if (attacker.Health <= 0)
            {
                Console.WriteLine($"{attacker.Name} is defeated.");
                return target.Health;
            }
            else
            {
                Console.WriteLine($"{target.Name} is defeated.");
                return attacker.Health;

            }
        }
    }
}



