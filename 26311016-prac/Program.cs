namespace _26311016_prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("나의 이력서");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("이름: 홍길동");
            Console.SetCursorPosition(10, 12);
            Console.WriteLine("생년월일: 1990년 1월 1일");
        }
    }
}