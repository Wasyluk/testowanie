using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp6
{
    internal class Program
    {
        static class DiceGame
        {
            static public void setDiceNumber()
            {
                int numberOfDice = 0;
                do
                {
                    Console.WriteLine("Ile kostek chcesz rzucić? (3 - 10)");
                    numberOfDice = int.Parse(Console.ReadLine());
                } while (numberOfDice < 3 || numberOfDice > 10);

                DiceGame.DiceCount = numberOfDice;
            }

            static public void play() 
            {
                bool continueGame = false;
                do
                {
                    DiceGame.rollDice();
                    DiceGame.countPoints();

                    for (int i = 0; i < DiceGame.DiceCount; i++)
                    {
                        Console.WriteLine("Kostka " + (i + 1) + ": " + DiceGame.DiceValues[i]);
                    }

                    Console.WriteLine(DiceGame.Points);

                    Console.WriteLine("Jeszcze raz? (t/n)");

                    char continueGameChar = 'n';
                    do
                    {
                        continueGameChar = Console.ReadKey().KeyChar;
                    } while (continueGameChar != 'n' && continueGameChar != 't');

                    Console.WriteLine();

                    continueGame = continueGameChar == 't' ? true : false;
                } while (continueGame);
            }

            static int diceCount;
            static private int DiceCount 
            {  
                get { return diceCount;}
                set 
                { 
                    if(value >=3 && value <=10)
                        diceCount = value;
                }
            }

            static int[]? diceValues;
            static private int[]? DiceValues { get { return diceValues; } }

            static int points;
            static private int Points { get { return points; } }

            static private void rollDice()
            {
                Random rnd = new Random();
                diceValues = new int[diceCount];
                for(int i = 0; i < diceCount; i++)
                {
                    diceValues[i] = rnd.Next(1,7);
                }
            }

            static private void countPoints() 
            { 
                points = 0;
                if(diceValues!=null)
                {
                    List<int> countedDice = new List<int>();
                    for(int i = 0;i < diceValues.Length;i++) 
                    { 
                        for(int j = 0;j < diceValues.Length; j++)
                        {
                            if (i == j)
                                continue;
                            if (diceValues[i] == diceValues[j])
                            {
                                countedDice.Add(diceValues[i]);
                                points += diceValues[i];
                                break;
                            }
                        }
                    }
                    
                    
                }
              
            }
        }

        static void Main(string[] args)
        {
            DiceGame.setDiceNumber();
            DiceGame.play();
        }
    }
}
