namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What city were you born in?");
            string userCityBornIn = Console.ReadLine();

            Console.WriteLine("What is your favorite city to visit?");
            string userFavoriteCityToVisit = Console.ReadLine();

            Console.WriteLine("What is your dream job?");
            string userDreamJob = Console.ReadLine();

            Console.WriteLine("If you could be any superhero, who would you be?");
            string userSuperhero = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"He was born in {userCityBornIn}, his favorite city in the world to visit was {userFavoriteCityToVisit}.");
            Console.WriteLine($"{userName} one day dreamed of being a {userDreamJob}.");
            Console.WriteLine($"{userName} secretly wanted to be {userSuperhero}!");





            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to add");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the second one");
            int num3 = int.Parse(Console.ReadLine());

            int sum2= Sum(Num1, Num2, num3);
            Console.WriteLine($"The sum2 is: {sum2}");

            Console.WriteLine("Give me a number to add");
            int NUm1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int NUm2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the second one");
            int NUm3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Give me a number to add to the thrid one");
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the fourth one");
            int num5 = int.Parse(Console.ReadLine());

            int sum3 = Sum(NUm1, NUm2, NUm3, num4, num5);
            Console.WriteLine($"The sum3 is: {sum3}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");




        }

        public static int Sum(params int[] list)
        {

            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            { 
               sum = sum + list[i];

            }
            return sum;
        }
        

        public static int Multiply(int x, int y) 
        {

            return x * y;


        }
    }
}
