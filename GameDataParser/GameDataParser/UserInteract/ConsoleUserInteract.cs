namespace GameDataParser.UserInteract
{
    public class ConsoleUserInteract : IUserInteractor
    {
        public void PrintError(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            PrintMessage(message);
            Console.ForegroundColor = originalColor;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadValidFile()
        {
            bool isValidPath = false;
            string fileName = default;
            do
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                fileName = Console.ReadLine();
                if (fileName is null)
                {
                    Console.WriteLine("The file name cannot be null");
                }
                else if (fileName == string.Empty)
                {
                    Console.WriteLine("The file name cannot be empty");
                }
                else if (!File.Exists(fileName))
                {
                    Console.WriteLine("The file does not exist");
                }
                else
                {
                    isValidPath = true;
                }
            } while (!isValidPath);

            return fileName;
        }
    }
}