namespace kostki
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("ile kostek chcesz rzucic? || q by wyjsc");
                string DiceCount = Console.ReadLine();

                if(DiceCount == "q")
                {
                    break;
                }

                if (int.TryParse(DiceCount, out int number))
                {
                    if (number > 0 && number < 11)
                    {
                        Dice.RollDice(number);
                    }
                    else
                    {
                        Console.WriteLine("liczba ma byc od 0 do 10");
                    }
                }
                else
                {
                    Console.WriteLine("wpisz liczbe");
                }
            }
        }
    }
}
