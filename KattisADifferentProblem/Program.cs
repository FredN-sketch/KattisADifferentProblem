/* https://open.kattis.com/problems/different
Contents of problems.txt

10 12
71293781758123 72784
1 12345677654321
1 8

 */

namespace KattisADifferentProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Enter numbers: ");
            string[] input = Console.ReadLine().Split();
            int number1 = int.Parse(input[0]);
            int number2 = int.Parse(input[1]);
            int difference = int.Abs(number1 - number2);
            Console.WriteLine(difference);
            Console.ReadLine();
            */

            String line;
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\KattisADifferentProblem\problem.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                string[] input = line.Split();
                long number1 = long.Parse(input[0]);
                long number2 = long.Parse(input[1]);
                long difference = long.Abs(number1 - number2);
                Console.WriteLine(difference);       
                line = sr.ReadLine();   
            }
            Console.ReadLine(); 
        }
    }
}
