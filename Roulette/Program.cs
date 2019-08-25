using System.Collections.Generic;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            new App().Run();
        }
    }

    public class App
    {
        public void Run()
        {
            new Wheel().BetSelect();
        }
    }
}
