// See https://aka.ms/new-console-template for more information
namespace calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Tell me your name:");
      var name = Console.ReadLine();
      var currentDate = DateTime.Now;
      Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
      Console.Write($"{Environment.NewLine}Press any key to exti...");
      Console.ReadKey(true);
    }
  }
}
