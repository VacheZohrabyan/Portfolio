using DiceRoleGame;

namespace DiceRoleGame
{
    class Project
    {
        static void Main(string[] args)
        {
            DiceRoleGame diceRoleGame = new DiceRoleGame();
            Message message = new Message();
            Console.WriteLine(message.WelcomeMessage());
            Input input = new Input(diceRoleGame, message);
            input.ConsoleInput();
            Console.ReadKey();
        }
    }
}
