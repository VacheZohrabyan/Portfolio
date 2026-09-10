 namespace DiceRoleGame
{
    public class DiceRoleGame
    {
        public readonly int RundomNumber;

        public DiceRoleGame()
        {
            RundomNumber = GenerateRundomNumber();
        }

        private int GenerateRundomNumber()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}