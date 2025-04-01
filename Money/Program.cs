namespace Money
{
    public class BankruptcyException : Exception
    {
        public BankruptcyException(string message) : base(message) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Money num1 = 100;
            Money num2 = 200;


            try
            {
                CheckResult(num1 + num2, "Сложение");
                CheckResult(num2 - num1, "Вычитание");
                CheckResult(num1 * 2, "Умножение");
                CheckResult(num1 / 2, "Деление");
                Console.WriteLine(num1 == num2);
                Console.WriteLine(num1 != num2);
                Console.WriteLine(num1 > num2);
                Console.WriteLine(num1 < num2);
                CheckResult(num1++, "+0.1");
                CheckResult(num2++, "+0.1");
                CheckResult(num1--, "-0.1");
                CheckResult(num2--, "-0.1");
            }
            catch (BankruptcyException ex)
            {
                Console.WriteLine($"ERROR\n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR\n{ex.Message}");
            }
        }


        static void CheckResult(Money result, string operation)
        {
            if (result.Sum < 0)
            {
                throw new BankruptcyException($"Вы обанкротились!! Результат операции {operation} меньше 0: {result.Sum}");
            }
            Console.WriteLine($"{operation}: {result.Sum}");
        }
    }
}
