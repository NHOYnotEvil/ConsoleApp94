namespace ConsoleApp94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bracketExpression;
            int currentDepthExpression = 0;
            int maxDepthExpression = 0;
            char bracketLeft = '(';
            char bracketRight = ')';

            Console.Write("Введите скобочное выражение: ");
            bracketExpression = Console.ReadLine();

            for (int i = 0; i < bracketExpression.Length; i++)
            {
                if (bracketExpression[i] == bracketLeft)
                {
                    currentDepthExpression++;
                }
                else if (bracketExpression[i] == bracketRight) 
                {
                    currentDepthExpression--;
                }

                if (currentDepthExpression > 0)
                {
                    maxDepthExpression++;
                }

                Console.WriteLine("Ваша текущая глубина выражения: " + currentDepthExpression);
                Console.WriteLine("Ваша максимальная глубина выражения: " + currentDepthExpression);
            }
        }
    }
}