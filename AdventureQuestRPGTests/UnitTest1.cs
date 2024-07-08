using Xunit;
using System;
using System.IO;
namespace AdventureQuestRPG.Tests
{
    public class AdventureTests
    {
        [Fact]
        public void NewLocationTest()
        {
            // Arrange
            int firstMap = 1;
            int secondMap = 2;
            
            var input = new StringReader("yes\nyes");
            TextReader originalInput = Console.In; 
            Console.SetIn(input);
            try
            {
                // Act
                string first = Adventure.ChooseMap(firstMap);
                string second = Adventure.ChooseMap(secondMap);
                // Assert
                Assert.NotEqual(first, second);
            }
            finally
            {
                
                Console.SetIn(originalInput);
            }
        }
        [Fact]
        public void FindAndEncounterBoss()
        {
            // Arrange
            Ibrahim ibrahim = new Ibrahim();
            Monster monster = Adventure.Monsters[4];
            
            var input = new StringReader("no\n");
            TextReader originalInput = Console.In; 
            Console.SetIn(input);
            try
            {
                // Act
                BattleSystem.StartBattle(ibrahim, monster);
                // Assert
                Assert.True(monster.Health > 0);
            }
            finally
            {
                
                Console.SetIn(originalInput);
            }
        }
       
        [Fact]
        public void HealthTest()
        {
            //Arrange
            Raghad attacker = new Raghad();
            GiantSpiders target = new GiantSpiders();
            
            var input = new StringReader("no\nno\n");
            TextReader originalInput = Console.In; 
            Console.SetIn(input);
            try
            {
                //Act
                BattleSystem.Attack(attacker, target);
                BattleSystem.Attack(target, attacker);
                //Assert
                Assert.Equal(20, target.Health);
                Assert.Equal(95, attacker.Health);
            }
            finally
            {
                
                Console.SetIn(originalInput);
            }
        }
        [Fact]
        public void WinnerTest()
        {
            //Arrange
            Raghad attacker = new Raghad();
            GiantSpiders target = new GiantSpiders();
            
            var input = new StringReader("no\nno\n");
            TextReader originalInput = Console.In; 
            Console.SetIn(input);
            try
            {
                //Act
                int result = BattleSystem.StartBattle(attacker, target);
                //Assert
                Assert.True(result > 0);
            }
            finally
            {
               
                Console.SetIn(originalInput);
            }
        }
    }
}