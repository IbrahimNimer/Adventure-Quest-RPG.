# AdventureQuestRPG

This is a console application designed to simulate a battle between a player and a monster in an RPG setting. It includes classes for characters, players, and monsters, along with a battle system to manage the combat.

## Purpose of the Program

The purpose of this program is to provide a simple yet engaging way to simulate RPG battles. Users can create players and monsters with specific attributes and watch them battle it out until one is defeated. This project ensures robust and reliable functionality for managing character attributes and battle mechanics.

## Instructions on How to Run the Program

1. **Clone or download the repository**: Ensure you have the source code on your local machine.

2. **Open the project**:
   - Use an IDE like Visual Studio or any C# compatible editor to open the project.

3. **Build the project**:
   - Ensure all dependencies are resolved and build the project.

4. **Run the program**:
   - Execute the program by running the `AdventureQuestRPG` executable.
   - Alternatively, you can run the program directly from the IDE by pressing `F5` or selecting the "Run" option.

5. **Simulate Battles**:
   - The program will automatically simulate a battle between a player and a monster.
   - Follow the prompts and output messages to see the battle progress and its outcome.

## Additional Information or Notes

- **Creating Characters**:
  - The `Characters` class serves as a base class for both `Player` and `Monster` classes.
  - Players and monsters have attributes such as `Name`, `Health`, `AttackPower`, and `Defense`.

- **Battle System**:
  - The `BattleSystem` class manages the battle mechanics.
  - Use the `StartBattle` method to initiate a battle between a player and a monster.
  - The `Attack` method handles the attack logic and updates the health of the target.

- **Error Handling**:
  - The program includes error handling to manage invalid inputs and other exceptions gracefully.
  - Exceptions are caught and printed to the console, ensuring the program does not crash unexpectedly.

- **Unit Tests**:
  - The `AdventureQuestRPGTests` project includes unit tests to verify the functionality of the battle system.
  - Use the `HealthTest` method to test the health update after an attack.
  - Use the `WinnerTest` method to ensure the battle system correctly determines the winner.

Enjoy simulating epic battles with the AdventureQuestRPG application!
