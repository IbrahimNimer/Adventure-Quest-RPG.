namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player attacker = new Player("Ibrahim", 10, 5, 3);
                Monster target = new Monster("Dragon", 10, 4, 3);
                BattleSystem.StartBattle(attacker, target);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Match End");
            }
        }
    }
}



