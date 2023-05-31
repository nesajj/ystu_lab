namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, result = 0;
            int op;
            Console.WriteLine("Первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1.Сложение\n2.Вычетание\n3.Умножение\n4.Деление");
            op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1: result= a + b; break;
                case 2: result= a - b; break;
                case 3: result= a * b; break;
                case 4: if (b == 0)
                    {
                        Console.WriteLine("Деление на 0 невозможно!");
                        return;
                    }
                        result = a / b;
                        break;
                    
            }
            Console.Write("Ответ: " + result); 
        }
    }
}