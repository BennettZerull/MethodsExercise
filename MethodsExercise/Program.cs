namespace MethodsExercise
{
    public class Program
    {public static void FantasyStory()
        {
            Console.WriteLine("Whoa their traveler, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("So you're a fantasy adventurer huh, what class are you?");
            string fantasyClass = Console.ReadLine();
            Console.WriteLine("Tell me where did your adventure begin?");
            string startingPoint = Console.ReadLine();
            Console.WriteLine("Wasn't that place was overrun with Bandits; how did you fight them off?");
            string weaponChoice = Console.ReadLine();
            Console.WriteLine($"I can't wait to hear The Bard's song of {name}, the great {fantasyClass}, who fought off the Bandits of {startingPoint} with their {weaponChoice}. It shall be sung for ages!!!");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            FantasyStory();
            //Console.WriteLine(Add(5, 3));
            //Console.WriteLine(Subtract(10, 7));
            //Console.WriteLine(Multiply(8, 6));
            //Console.WriteLine(Divide(100, 10));
            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9));
        }
    }
}