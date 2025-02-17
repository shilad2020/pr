
namespace CosoleApp1
{
	public enum Fruits
	{
        Apple, Mangno, Orange
    }
	internal class Program
	{
		static	void Main(string[] args)
		{
             Console.WriteLine("Hello, World!");
            var ch = Console.ReadLine();
            Fruits fruits = new Fruits();
          //  Maths maths = new Maths();
            switch (fruits)
            {
                case Fruits.Apple: break;
                case Fruits.Mangno: break;
                case Fruits.Orange: break;
                default:
                    break;
            }

        }
    }
}
