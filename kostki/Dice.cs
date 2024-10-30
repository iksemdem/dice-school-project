namespace kostki
{
    internal class Dice
    {
        public static void RollDice(int number)
        {
            Random rand = new Random();

            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int randNumb = rand.Next(1, 7);

                switch (randNumb)
                {
                    case 1:
                        Console.WriteLine($"rzut {i + 1}: 1");
                        sum += 1;
                        break;
                    case 2:
                        Console.WriteLine($"rzut {i + 1}: 2");
                        sum += 2;
                        break;
                    case 3:
                        Console.WriteLine($"rzut {i + 1}: 3");
                        sum += 3;
                        break;
                    case 4:
                        Console.WriteLine($"rzut {i + 1}: 4");
                        sum += 4;
                        break;
                    case 5:
                        Console.WriteLine($"rzut {i + 1}: 5");
                        sum += 5;
                        break;
                    case 6:
                        Console.WriteLine($"rzut {i + 1}: 6");
                        sum += 6;
                        break;  
                    default:
                        Console.WriteLine("jakis blad bo liczba jest mniejsza od 1 albo wieksza od 6 nie wiem");
                        break;
                }
            }
            Console.WriteLine($"suma z kostkow to: {sum}");
        }

    }
}
