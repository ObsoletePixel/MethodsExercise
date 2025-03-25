namespace MethodsExercise 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var yourName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();

            Console.WriteLine("Where are you from?");
            var hometown = Console.ReadLine();

            IntroGen(yourName, age, hometown);
        }

        static void IntroGen(string yourName, string age, string hometown)
        {
            Console.WriteLine($"Hello! My name is {yourName}, I am {age}, and I am from {hometown}. It's nice to meet you!");
        }
        
    }
};