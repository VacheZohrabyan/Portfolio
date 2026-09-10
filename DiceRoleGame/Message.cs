namespace DiceRoleGame
{
    public class Message
    {
        public string WelcomeMessage() => "Dice rolled. Guess what number it shows in 3 tries.";

        public string InputMessage() => "Enter a number: ";
        public string WinMessage() => "You win!";
        public string WrongMessage() => "Wrong number.";
        public string LoseMessage() => "You lose :(";
    }
}