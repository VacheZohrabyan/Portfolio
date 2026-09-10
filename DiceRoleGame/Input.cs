namespace DiceRoleGame
{
    public class Input
    {
        private DiceRoleGame _diceRoleGame;
        private Message _message;
        private const int _step = 3;
        public Input(DiceRoleGame diceRoleGame, Message message)
        {
            _diceRoleGame = diceRoleGame;
            _message = message;
        }
        
        public void ConsoleInput()
        {
            int fakeStep = 0;
            while (fakeStep != _step)
            {
                Console.WriteLine(_message.InputMessage());
                string? isStringNumber = Console.ReadLine();
                if (isStringNumber != "" && int.TryParse(isStringNumber, out int number) && number >= 1 && number <= 6)
                {
                    if (_diceRoleGame.RundomNumber == number)
                    {
                        Console.WriteLine(_message.WinMessage());
                        return;
                    }
                    Console.WriteLine(_message.WrongMessage());
                }
                fakeStep++;
            }
            if (fakeStep == _step)
            {
                Console.WriteLine(_message.LoseMessage());
            }
        }
    }
}